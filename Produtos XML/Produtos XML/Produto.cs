using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Produtos_XML
{
    [XmlRoot("produto")]
    public class Produto
    {
        [XmlElement("nome")]
        public string Nome { get; set; }

        [XmlElement("preco")]
        public double Preco { get; set; }

        [XmlElement("descricao")]
        public string Descricao { get; set; }

        [XmlElement("categoria")]
        public string Categoria { get; set; }
    }
}
