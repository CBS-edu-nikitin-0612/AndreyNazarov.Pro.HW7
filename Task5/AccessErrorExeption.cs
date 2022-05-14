using System;

namespace Task5
{
    internal class AccessErrorExeption : Exception
    {
        public override string Message => "Ошибка доступа";
    }
}
