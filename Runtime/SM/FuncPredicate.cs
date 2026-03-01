using System;

namespace MyUnityKit.SM {
    public class FuncPredicate : IPredicate {
        readonly Func<bool> predicate;

        public FuncPredicate(Func<bool> predicate) {
            this.predicate = predicate;
        }

        public bool Evaluate() => predicate.Invoke();
    }
}