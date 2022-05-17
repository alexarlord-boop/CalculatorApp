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
        private class CalcManager
        {
            private readonly Form1 form;
            private int SecLock { get; set; }
            private readonly ConcurrentQueue<Expression> QueueRequests;
            private readonly ConcurrentQueue<double> QueueResults;

            public CalcManager(Form1 form)
            {
                this.form = form;
                QueueRequests = new ConcurrentQueue<Expression>();
                QueueResults = new ConcurrentQueue<double>();
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
            public void AddResult(double equation)
            {
                QueueResults.Enqueue(equation);
                UpdateResultCount();
            }
            public void AddLineToJournal(Expression exp, double res)
            {
                StringBuilder sb = new StringBuilder(exp.getCanonicalExpressionString());
                sb.Append(" = ").Append(res.ToString());

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
                bool gotRequest = QueueRequests.TryDequeue(out Expression expression);
                if (gotRequest)
                {
                    form.Invoke((MethodInvoker)delegate
                    {
                        form.messageLabel2.Text = expression.getCanonicalExpressionString();
                    });

                    UpdateRequestCount();

                    AddResult(expression.calculate());
                    Thread.Sleep(SecLock * 1000);
                    QueueResults.TryDequeue(out double result);

                    AddLineToJournal(expression, result);
                }
            }
            public void ThreadCalculation(ref bool cancel)
            {
                while (!cancel && QueueRequests.Count > 0)
                {
                    try
                    {
                        Calculation();
                    }
                    catch (Exception ex)
                    {
                        form.Invoke((MethodInvoker)delegate
                        {
                            form.messageLabel.Text = ex.GetBaseException().ToString();
                        });
                    }
                }

                UpdateResultCount();
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
    }
    
}
