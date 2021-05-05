using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public class Calculator
    {
        private readonly Logger _logger;

        public Calculator()
        {
            _logger = Logger.GetLogger();
        }

        public void Divide(int a, int b)
        {
            try
            {
                var result = a / b;
                Console.WriteLine(result);
            }
            catch (Exception exception)
            {
                _logger.Log(exception.Message);
            }
        }

    }
}
