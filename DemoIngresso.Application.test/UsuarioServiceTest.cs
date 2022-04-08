using DemoIngresso.Application.Services;
using DemoIngresso.Domain.Entidade;
using DemoIngresso.Domain.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace DemoIngresso.Application.test
{
    public class UsuarioServiceTest
    {
        private Usuario? _model;
        private IUsuarioService? _service;

        [SetUp]
        public void UsuarioServiceTests()
        {
            _service = new UsuarioService();
        }

        [Test]
        public void InsertUsuario()
        {
            _model = new Usuario()
            {
                Nome = "Xuxando Muito voce"
            };

            var result = _service?.InsertUsuario(_model);

            result?.IsCompletedSuccessfully.Should().BeFalse();
        }
    }
}