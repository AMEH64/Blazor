using Bunit;
using Bunit.Rendering;
using Microsoft.AspNetCore.Components;
using NUnit.Framework;
using System;

namespace UnitTests.Components
{
    public abstract class BunitTestBase : IDisposable
    {
        private Bunit.TestContext _Context;

        public ITestRenderer Renderer => _Context?.Renderer ?? throw new InvalidOperationException("NUnit has not started executing tests yet");

        public TestServiceProvider Services => _Context?.Services ?? throw new InvalidOperationException("NUnit has not started executing tests yet");

        public void Dispose()
        {
            _Context?.Dispose();
            _Context = null;
        }

        [SetUp]
        public void Setup() => _Context = new Bunit.TestContext();

        [TearDown]
        public void TearDown() => Dispose();

        public IRenderedComponent<TComponent> RenderComponent<TComponent>(params ComponentParameter[] parameters)
            where TComponent : IComponent
            => _Context?.RenderComponent<TComponent>(parameters) ?? throw new InvalidOperationException("NUnit has not started executing tests yet");

        public IRenderedComponent<TComponent> RenderComponent<TComponent>(Action<ComponentParameterCollectionBuilder<TComponent>> parameterBuilder)
            where TComponent : IComponent
            => _Context?.RenderComponent<TComponent>(parameterBuilder) ?? throw new InvalidOperationException("NUnit has not started executing tests yet");
    }
}
