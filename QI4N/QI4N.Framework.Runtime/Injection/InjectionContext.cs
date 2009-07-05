namespace QI4N.Framework.Runtime
{
    public class InjectionContext
    {
        // For mixins
        public InjectionContext(CompositeInstance compositeInstance, UsesInstance uses, StateHolder state)
        {
            this.CompositeInstance = compositeInstance;
            this.Module = compositeInstance.ModuleInstance;
            this.Uses = uses;
            this.State = state;
            this.Next = null;
            this.ProxyHandler = null;
        }

        // For concerns and side-effects
        public InjectionContext(ModuleInstance moduleInstance, object next, ProxyReferenceInvocationHandler proxyHandler)
        {
            this.CompositeInstance = null;
            this.Module = moduleInstance;
            this.Uses = null;
            this.Next = next;
            this.State = null;
            this.ProxyHandler = proxyHandler;
        }

        public CompositeInstance CompositeInstance { get; private set; }

        public Module Module { get; private set; }

        public object Next { get; private set; }

        public ProxyReferenceInvocationHandler ProxyHandler { get; private set; }

        public StateHolder State { get; private set; }

        public UsesInstance Uses { get; set; }
    }
}