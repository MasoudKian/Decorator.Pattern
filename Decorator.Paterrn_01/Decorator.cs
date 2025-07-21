using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pattern_01
{
    public abstract class Decorator : Component
    {
        // Only accessible inside this class and cannot be changed after constructor
        private readonly Component _component;

        public Decorator(Component component)
        {
            _component = component; // can only be set here
        }

        public override void Operation()
        {
            if (_component != null)
            {
                _component.Operation();
            }
        }
    }

    #region private

    //     Explanation(Version 1) :
    
    //private readonly Component _component;
    //👉 _component is only accessible inside Decorator itself.
    //👉 Because of readonly, _component can only be assigned in the constructor and cannot be changed later.
    
    //Child classes that inherit from Decorator cannot access _component directly.
    
    //When to use:
    //✅ When you want the decorated component to be immutable and only handled by Decorator internally.

    #endregion

    public class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(Component component) : base(component)
        {
        }
        public override void Operation() 
        {
            base.Operation();
            Console.WriteLine("ConcreteDecorator Operation is running new Operation...");
            Console.ReadLine();
        }
    }



    #region protected

    //public abstract class Component
    //{
    //    public abstract void Operation();
    //}

    //public abstract class Decorator : Component
    //{
    //    // Accessible inside this class and all child classes
    //    protected Component _component;

    //    public Decorator(Component component)
    //    {
    //        _component = component; // can be changed later if needed
    //    }

    //    public override void Operation()
    //    {
    //        if (_component != null)
    //        {
    //            _component.Operation();
    //        }
    //    }
    //}

    ///////---------------------------------------------------------------\\\\\\\\\\\

    //    ✔️ Explanation(Version 2) :

    //protected Component _component;
    //👉 _component is accessible inside this class and all subclasses of Decorator.
    //👉 Because it’s not readonly, you can change _component later in the child classes or within the same class.

    //When to use:
    //✅ When you want subclasses of Decorator to have direct access and possibly replace or modify _component after construction.

    #endregion
}
