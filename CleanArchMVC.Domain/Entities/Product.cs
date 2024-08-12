using CleanArchMVC.Domain.Validation;

namespace CleanArchMVC.Domain.Entities
{
    public sealed class Product :Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string Image {  get; private set; }

        public Product(string name, string description, decimal price, int stock, string image)
        {
            ValidateDomain(name, description, price, stock, image);
        }

        public Product(int id, string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.When(id < 0, "Valor Inválido");
            Id = id;
            ValidateDomain(name, description, price, stock, image);
        }

        public void Update(string name, string description, decimal price, int stock, string image, int categoryId)
        {
            ValidateDomain(name, description, price, stock, image);
            CategoryId = categoryId;
        }

        private void ValidateDomain(string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), $"Nome Inválido. Nome é requerido");

            DomainExceptionValidation.When(name.Length < 3, $"Nome Inválido. Mínimo de 3 Caracteres");
            
            DomainExceptionValidation.When(string.IsNullOrEmpty(description) , $"Descrição Inválida. Descrição é requerida");

            DomainExceptionValidation.When(description.Length < 5, $"Descrição Inválida. Mínimo de 5 Caracteres");

            DomainExceptionValidation.When(price < 0, $"Preço inválido. Deve ser maior que zero(0)");

            DomainExceptionValidation.When(stock < 0, $"Estoque Inválido. Deve ser maior que zero(0)");

            DomainExceptionValidation.When(image?.Length > 250, $"Nome da Imagem Inválido. Máximo de 250 Caracteres");
        }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
