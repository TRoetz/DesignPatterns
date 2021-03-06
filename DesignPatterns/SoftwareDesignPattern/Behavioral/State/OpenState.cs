﻿namespace DesignPatterns.SoftwareDesignPattern.Behavioral.State {
  public class OpenState : ITurnstileState {
    public ITurnstileState Alarm() => new ClosedState();

    public ITurnstileState Enter() => new ClosedState();

    public ITurnstileState Pay() => this;

    public ITurnstileState PayFailed() => this;

    public ITurnstileState PayOk() => this;

    public string GetCurrentState() => "Open";
  }
}
