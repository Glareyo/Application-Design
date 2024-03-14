using CalculatorNS;

namespace Calculator_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Calculator c;
        float result;

        public UnitTest1()
        {
            c = new Calculator();
            result = 0;
        }

        #region Operations Tests
        [TestMethod]
        public void InputsAreInputtedTest()
        {
            float input1 = 10;
            float input2 = 14;

            c.AddInput(input1);
            c.AddInput(input2);
            c.SetOperation(Operation.Add);

            c.ComputeInputs(out result);
            c.Clear();

            Assert.AreEqual(input1 + input2, result);
        }


        [TestMethod]
        public void AdditionTest()
        {
            c.AddInput(10);
            c.AddInput(10);
            c.SetOperation(Operation.Add);

            c.ComputeInputs(out result);

            c.Clear();
            
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void SubtractionTest()
        {
            c.AddInput(10);
            c.AddInput(10);

            c.SetOperation(Operation.Subtract);
            c.ComputeInputs(out result);
            
            c.Clear();

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void DivideTest()
        {
            c.AddInput(10);
            c.AddInput(10);

            c.SetOperation(Operation.Divide);
            c.ComputeInputs(out result);

            c.Clear();

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            c.AddInput(10);
            c.AddInput(10);

            c.SetOperation(Operation.Multiply);
            c.ComputeInputs(out result);

            c.Clear();

            Assert.AreEqual(100, result);
        }
        #endregion

        #region Calculator Methods Tests
        [TestMethod]
        public void ErrorOccursCatch()
        {
            bool valid;

            c.AddInput(10);
            c.AddInput(0);

            c.SetOperation(Operation.Divide);
            valid = c.ComputeInputs(out result);

            c.Clear();

            Assert.AreEqual(valid, false);
        }

        [TestMethod]
        public void OperationIsValid()
        {
            bool valid;

            c.AddInput(10);
            c.AddInput(0);

            c.SetOperation(Operation.Multiply);
            valid = c.ComputeInputs(out result);

            c.Clear();

            Assert.AreEqual(valid, true);
        }

        [TestMethod]
        public void SettingOperationsTest()
        {
            float resultAdd = 0;
            float resultSubtract = 0;
            float resultMultiply = 0;
            float resultDivide = 0;

            c.AddInput(10);
            c.AddInput(10);

            c.SetOperation(Operation.Add);
            c.ComputeInputs(out resultAdd);

            c.SetOperation(Operation.Subtract);
            c.ComputeInputs(out resultSubtract);

            c.SetOperation(Operation.Multiply);
            c.ComputeInputs(out resultMultiply);

            c.SetOperation(Operation.Divide);
            c.ComputeInputs(out resultDivide);

            c.Clear();

            Assert.AreEqual(resultAdd, 20);
            Assert.AreEqual(resultSubtract, 0);
            Assert.AreEqual(resultMultiply, 100);
            Assert.AreEqual(resultDivide, 1);
        }

        [TestMethod]
        public void CalculatorClearsTest()
        {
            c.AddInput(10);
            c.AddInput(10);
            c.SetOperation(Operation.Add);

            c.Clear();

            c.ComputeInputs(out result);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void IsACalculator()
        {
            Assert.IsInstanceOfType<Calculator>(c);
        }

        #endregion
    }
}