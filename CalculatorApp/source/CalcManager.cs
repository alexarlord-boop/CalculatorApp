using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public class CalcManager
        {
            private readonly Form1 form;
            private int SecLock { get; set; }
            private readonly ConcurrentQueue<Expression> QueueRequests;
            private readonly ConcurrentQueue<Equation> QueueResults;

            public CalcManager(Form1 form)
            {
                this.form = form;
                QueueRequests = new ConcurrentQueue<Expression>();
                QueueResults = new ConcurrentQueue<Equation>();
                UpdateSecLock();
            }


            public int GetRequestCount()
            {
                return QueueRequests.Count;
            }
            public void UpdateSecLock()
            {
                SecLock = Convert.ToInt32(form.secondsSelector.Value);
            }
            public void UpdateRequestCount()
            {
                form.Invoke((MethodInvoker)delegate
                {
                    form.requestsCountLabel.Text = QueueRequests.Count().ToString();
                });
            }
            public void UpdateResultCount()
            {
                form.Invoke((MethodInvoker)delegate
                {
                    form.resultsCountLabel.Text = QueueResults.Count().ToString();
                });
            }


            public void AddRequest(Expression expression)
            {
                QueueRequests.Enqueue(expression);
                UpdateRequestCount();
            }
            public void AddResult(Equation eq)
            {
                QueueResults.Enqueue(eq);
                UpdateResultCount();
            }
            public void AddLineToJournal(Equation equation)
            {
                StringBuilder sb = new StringBuilder(equation.expression.getCanonicalExpressionString());
                sb.Append(" = ").Append(equation.result.ToString());

                form.Invoke((MethodInvoker)delegate
                {
                    form.journalView.Items.Add(sb.ToString());
                });
            }


            public bool IsValidExpression(string expression)
            {
                string zeroDivisionPattern = @".*\/0([^.]|$|\.(0{4,}.*|0{1,4}([^0-9]|$))).*";
                string msg = "";

                if (form.symbolAtTheEnd)
                {
                    msg = "Выражение не завершено";
                }
                else if (Regex.Match(expression, zeroDivisionPattern).Success)
                {
                    msg = "Деление на 0";
                }

                form.outTextBox.Text = msg;
                return msg.Equals("");
            }
            public void Calculation()
            {
                // 1. Берется следующий элемент (если он там есть)
                bool gotRequest = QueueRequests.TryDequeue(out Expression expression);
                if (gotRequest)
                {
                    form.Invoke((MethodInvoker)delegate
                    {
                        form.messageLabel2.Text = expression.getCanonicalExpressionString();
                    });
                    UpdateRequestCount();
                    // 2. Извлеченный элемент отправляется на обработку.
                    Equation eq = new Equation { expression = expression, result = expression.calculate() };
                    AddResult(eq);
                    // 3. Ожидание...
                    Thread.Sleep(SecLock * 1000);
                    // ...и вывод результата методом ShowResult

                }
            }
            public void ShowResult()
            {
                // ...и вывод результата.
                QueueResults.TryDequeue(out Equation equation);
                AddLineToJournal(equation);
                UpdateResultCount();
            }
            public void ThreadCalculation(ref bool cancel)
            {
                while (!cancel && QueueRequests.Count > 0)
                {
                    try
                    {
                        Calculation();
                        ShowResult();
                    }
                    catch (Exception ex)
                    {
                        form.Invoke((MethodInvoker)delegate
                        {
                            form.messageLabel.Text = ex.GetBaseException().ToString();
                        });
                    }
                }

                Terminate("Requests queue is empty");
                cancel = true;
            }
            public void Terminate(string msg)
            {
                form.Invoke((MethodInvoker)delegate
                {
                    form.startBtn.Enabled = true;
                    form.stopBtn.Enabled = false;
                    form.messageLabel.Text = msg;
                    form.messageLabel2.Text = "";
                });
            }

        }

        public struct Equation
        {
            public Expression expression;
            public double result;
        }
    }
    
}
