using System;

namespace Homework12_2
{
    public class Power
    {
        private StdVoltage _voltage;
        public StdVoltage Voltage {
            get
            {
                if(_voltage != 0)
                {
                    return _voltage;
                }
                else
                {
                    Console.WriteLine("Voltage is not setup.");
                    return 0;
                }
            }
        }

        public Power(StdVoltage voltage)
        {
            _voltage = voltage;
        }

        public virtual void ShowVoltage()
        {
            Console.WriteLine("Power.ShowVoltage - Voltage = {0}", _voltage);
        }
    }
}
