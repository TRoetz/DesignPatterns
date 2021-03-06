﻿namespace DesignPatterns.SoftwareDesignPattern.Behavioral.State {
  public interface ITurnstileState {
    ITurnstileState Enter();

    ITurnstileState PayOk();

    ITurnstileState PayFailed();

    ITurnstileState Pay();

    ITurnstileState Alarm();

    string GetCurrentState();
  }
}
