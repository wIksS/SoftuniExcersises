using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Event ev = new Event();
            ev.internalField = 6;
            ev.publicField = 5;
            ev.DefaultInternalProperty = 7;
            
        }
    }

    public class Event
    {
         protected private int privateAndProtected;
        int defaultPrivateField;
        private int privateField = 0;
        protected int protectedField = 0;
        protected internal int internalField = 0;
        public int publicField = 0;

        public class PrivateEvent
        {

        }

        class DefaultClass
        {

        }

        public PrivateEvent PrivateEventInstance { get; set; }

        internal int DefaultInternalProperty { get; set; }

        void DefaultMethod()
        {

        }
    }

    class TennisEvent : Event
    {
        public void Start()
        {
            this.protectedField = 6;
            this.privateAndProtected = 5;
        }
    }
}
