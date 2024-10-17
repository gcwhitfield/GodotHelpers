using Godot;
using System;

public partial class Singleton<T> : Node where T : Singleton<T>
{
    public static T Instance { get; private set; }

    public override void _Ready() {
        if (Instance == null) {
            Instance = (T)this;
        } else {
            // Delete this if there is already an instance of the Singleton.
            QueueFree();
        }
    }
}
