namespace CalculatorNS
{
    public class Calculator
    {
        private float? firstNum     =   null;
        private float? secondNum    =   null;

        private Operation operation;

        public Calculator() { }

        public void AddInput(float num)
        {
            if (firstNum == null) firstNum = num;
            else secondNum = num;
        }

        public void SetOperation(Operation operation) 
        { 
            this.operation = operation;
        }

        public bool ComputeInputs(out float result)
        {
            float left  = firstNum != null ? firstNum.Value : 0;
            float right = secondNum != null ? secondNum.Value : 0;

            if(operation == Operation.Divide && right == 0)
            {
                result = 0;
                return false;
            }

            switch (operation)
            {
                case Operation.Add: result = left + right; break;
                case Operation.Subtract: result = left - right; break;
                case Operation.Multiply: result = left * right; break;
                case Operation.Divide: result = left / right; break;
                default: result = 0; return false;
            }

            return true;
        }   
        
        public void Clear()
        {
            firstNum = null;
            secondNum = null;
        }
    }
}