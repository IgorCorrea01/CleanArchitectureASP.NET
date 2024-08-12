using CleanArchMVC.Domain.Validation;

namespace CleanArchMVC.Domain.Entities
{
    public sealed class Category : Entity
    {
        public string Name { get; private set; }

        public Category(string name) 
        {
           ValidateDomain(name);
        }

        public Category(int id, string name) 
        {
            DomainExceptionValidation.When(id < 0, $"Id inválido");
            Id = id;
            ValidateDomain(name);
        }

        public ICollection<Product> Products { get; set; }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), $"Nome é requerido");

            DomainExceptionValidation.When(name.Length < 3, $"Nome Inválido. Mínimo de 3 Caracteres");

            Name = name;
        }
    }
}
