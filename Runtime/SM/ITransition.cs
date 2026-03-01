namespace MyUnityKit.SM {
    public interface ITransition {
        IState To { get; }
        IPredicate Condition { get; }
    }
}