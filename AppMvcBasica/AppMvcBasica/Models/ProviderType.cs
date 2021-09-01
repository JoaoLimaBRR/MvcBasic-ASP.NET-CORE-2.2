using System.ComponentModel;

namespace AppMvcBasica.Models
{
    public enum ProviderType
    {
        [DisplayName("Pessoa Fisíca")]
        PrivateIndividual = 1,
        [DisplayName("Pessoa Jurídica")]
        LegalPerson = 2
    }
}