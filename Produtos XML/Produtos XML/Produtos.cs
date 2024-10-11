using System.Xml.Serialization;

namespace Produtos_XML
{
    [XmlRoot("produtos")]
    public class Produtos
    {
        [XmlElement("produto")]
        public List<Produto> produtos;
    }
}
