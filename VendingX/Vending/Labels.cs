using System;
using System.Collections.Generic;
using System.Text;

namespace Vending
{
    class Labels
    {
        private static string[] messages =
            { "Изберете напитка: [номера в ляво]", "Въведете дължимата сума в монети от 0.1, 0.2, 0.5, 1.00, 2.00 лева!",
            "Благодарим Ви за покупката!", "лв!", "Имате ресто от => ", "Не ви достигат още ", "Твоята сметка е => " };
        public Labels() { }

        public static string[] Messages ()
        {
            return messages;
        }
    }
}
