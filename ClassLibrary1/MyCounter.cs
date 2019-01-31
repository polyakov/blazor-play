using System;

namespace ClassLibrary1
{
   public static class MyCounter
   {
      public static int Value;

      [Microsoft.JSInterop.JSInvokable]
      public static int IncrementValue( int increment = 1 )
      {
         Value += increment;
         return Value;
      }
   }
}
