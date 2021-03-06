﻿using System;
using DesignPatterns.SoftwareDesignPattern.Structural.Proxy.Protection;
using DesignPatterns.SoftwareDesignPattern.Structural.Proxy.Remote;
using DesignPatterns.SoftwareDesignPattern.Structural.Proxy.Virtual;
using DesignPatterns.Utilities;

namespace DesignPatterns.SoftwareDesignPattern.Structural.Proxy {
  public class ProxyPatternSample : IDesignPatternSample {
    public void ShowSample() {
      VirtualProxySample();
      ProtectionProxySample();
      RemoteProxySample();
    }

    private static void VirtualProxySample() {
      IExampleExpensiveObject withProxy = new VirtualProxy("JIT");
      IExampleExpensiveObject withoutProxy = new ExampleExpensiveObject("AOT");
      Console.WriteLine(withoutProxy.Text);
      Console.WriteLine(withProxy.Text);
    }

    private static void ProtectionProxySample() {
      var classWithoutPermission = new ProtectionProxy(false);
      ErrorUtilities.LogException(classWithoutPermission.SensitiveMethod);

      var classWithPermission = new ProtectionProxy(true);
      Console.WriteLine(classWithPermission.SensitiveMethod());
    }

    private static void RemoteProxySample() {
      var remoteProxy = new RemoteProxy();
      Console.WriteLine($"Will block until I get this data: {remoteProxy.GetData()}");
    }
  }
}
