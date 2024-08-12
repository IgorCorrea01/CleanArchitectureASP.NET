using CleanArchMVC.Domain.Entities;
using FluentAssertions;

namespace CleanArchMVC.Domain.Tests
{
    public class ProductUnitTest1
    {
        [Fact]
        public void CreateProduct_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Product(1, "Nome do Produto", "Descrição de Produto", 9.99m, 99, "imagem do produto");
            action.Should().NotThrow<CleanArchMVC.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_NegativeIdValue_DomainExceptionInvalidId()
        {
            Action action = () => new Product(-1, "Nome do Produto", "Descrição de Produto", 9.99m, 99, "imagem do produto");
            action.Should().Throw<CleanArchMVC.Domain.Validation.DomainExceptionValidation>().WithMessage("Valor Inválido");
        }

        [Fact]
        public void CreateProduct_ShortNameValue_DomainExceptionShortName()
        {
            Action action = () => new Product(1, "No", "Descrição de Produto", 9.99m, 99, "imagem do produto");
            action.Should().Throw<CleanArchMVC.Domain.Validation.DomainExceptionValidation>().WithMessage("Nome Inválido. Mínimo de 3 Caracteres");
        }

        [Fact]
        public void CreateProduct_LongImageName_DomainExceptionLongImageName()
        {
            Action action = () => new Product(1, "Nome de Produto", "Descrição de Produto", 9.99m, 99, "imagem do produtoooooooooooooooooooooooooooooooooooooooooo   ooooooooooo" +
                "ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo");
            action.Should().Throw<CleanArchMVC.Domain.Validation.DomainExceptionValidation>().WithMessage("Nome da Imagem Inválido. Máximo de 250 Caracteres");
        }

        [Fact]
        public void CreateProduct_WithNullImageName_NoDomainException()
        {
            Action action = () => new Product(1, "Nome de Produto", "Descrição de Produto", 9.99m, 99, null);
            action.Should().NotThrow<CleanArchMVC.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_WithNullImageName_NoNullReferenceException()
        {
            Action action = () => new Product(1, "Nome de Produto", "Descrição de Produto", 9.99m, 99, null);
            action.Should().NotThrow<NullReferenceException>();
        }

        [Fact]
        public void CreateProduct_WithEmptyImageName_NoDomainException()
        {
            Action action = () => new Product(1, "Nome de Produto", "Descrição de Produto", 9.99m, 99, "");
            action.Should().NotThrow<CleanArchMVC.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_InvalidPriceValue_DomainExceptionNegativeValue()
        {
            Action action = () => new Product(1, "Nome de Produto", "Descrição de Produto", -9.99m, 99, "imagem do produto");
            action.Should().Throw<CleanArchMVC.Domain.Validation.DomainExceptionValidation>().WithMessage("Preço inválido. Deve ser maior que zero(0)");
        }

        [Theory]
        [InlineData(-5)]
        public void CreateProduct_InvalidStockValue_DomainExceptionNegativeValue(int value)
        {
            Action action = () => new Product(1, "Nome de Produto", "Descrição de Produto", 9.99m, value, "imagem do produto");
            action.Should().Throw<CleanArchMVC.Domain.Validation.DomainExceptionValidation>().WithMessage("Estoque Inválido. Deve ser maior que zero(0)") ;
        }
    }
}
