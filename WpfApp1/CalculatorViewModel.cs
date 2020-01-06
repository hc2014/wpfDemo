using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfApp1
{
    public class CalculatorViewModel

    {

        CauculatorModel calculatorModel;

        private DeletgateCommand<string> addCommand;


        public CalculatorViewModel()

        {

            calculatorModel = new CauculatorModel();

        }



        #region Public Properties

        public string FirstOperand

        {

            get { return calculatorModel.FirstOperand; }

            set { calculatorModel.FirstOperand = value; }

        }

        public string SecondOperand

        {

            get { return calculatorModel.SecondOperand; }

            set { calculatorModel.SecondOperand = value; }

        }

        public string Operation

        {

            get { return calculatorModel.Operation; }

            set { calculatorModel.Operation = value; }

        }

        public string Result

        {

            get { return calculatorModel.Result; }

            set { calculatorModel.Result = value; }

        }

        #endregion



        public ICommand AddCommand

        {

            get

            {

                if (addCommand == null)

                {

                    addCommand = new DeletgateCommand<string>(Add, CanAdd);

                }

                return addCommand;



            }

        }



        public void Add(string x)

        {

            FirstOperand = x;

            SecondOperand = x;

            Result = (double.Parse(FirstOperand) + double.Parse(SecondOperand)).ToString();

            Operation = "+";

            MessageBox.Show(FirstOperand + Operation + SecondOperand + "=" + Result);

        }



        private static bool CanAdd(string num)

        {

            return true;

        }

    }
}
