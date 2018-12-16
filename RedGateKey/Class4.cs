using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Xsl;
using System.Security.Cryptography;

namespace RedGateKey
{
    internal class Class4
    {
        static Class4()
        {
            XmlDocument xmlDocument = new XmlDocument
            {
                PreserveWhitespace = true
            };
            xmlDocument.LoadXml("<?xml version='1.0' encoding='utf-8'?>\r<xsl:stylesheet version='1.0' xmlns:xsl='http://www.w3.org/1999/XSL/Transform' xmlns:msxsl='urn:schemas-microsoft-com:xslt' exclude-result-prefixes='msxsl'>\r  <xsl:output method='xml' indent='no' omit-xml-declaration='yes'/>\r  <xsl:param name='edition'/>\r  <xsl:param name='version'/>\r  <xsl:param name='userspurchased'/>\r  \r  <xsl:template match='activationrequest'>\r    <data>\r      <xsl:text>\r</xsl:text>\r      <xsl:apply-templates/>\r      <edition><xsl:value-of select='$edition'/></edition>\r      <xsl:text>\r</xsl:text>\r      <version><xsl:value-of select='$version'/></version>\r      <xsl:text>\r</xsl:text>\r      <userspurchased><xsl:value-of select='$userspurchased'/></userspurchased>\r      <xsl:text>\r</xsl:text>\r    </data>\r  </xsl:template>\r\r  <xsl:template match='machinehash'>\r    <machinehash>\r      <xsl:value-of select='text()'/>\r    </machinehash>\r    <xsl:text>\r</xsl:text>\r  </xsl:template>\r\r  <xsl:template match='productcode|majorversion|minorversion|serialnumber|session|edition|productname'>\r    <xsl:copy>\r      <xsl:value-of select='text()'/>\r    </xsl:copy>\r    <xsl:text>\r</xsl:text>\r  </xsl:template>\r\r  <xsl:template match='productcodes'>\r    <xsl:copy>\r      <xsl:text>\r</xsl:text>\r      <xsl:apply-templates />\r    </xsl:copy>\r    <xsl:text>\r</xsl:text>    \r  </xsl:template>\r\r  <xsl:template match='product'>\r    <xsl:copy>\r      <xsl:text>\r</xsl:text>\r      <xsl:apply-templates />\r    </xsl:copy>\r    <xsl:text>\r</xsl:text>\r  </xsl:template>\r\r  <xsl:template match='text()'/>\r</xsl:stylesheet>\r\n");
            Class4.xslCompiledTransform_0 = new XslCompiledTransform();
            Class4.xslCompiledTransform_0.Load(xmlDocument);
        }

        
        private static string smethod_0(string string_2)
        {
            RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider(new CspParameters
            {
                Flags = CspProviderFlags.UseMachineKeyStore
            });
            rsacryptoServiceProvider.FromXmlString("\r\n<RSAKeyValue>\r\n<Modulus>zLizNmLUd4VlIWee1GXgn/KxEwcghPASQ+NUzZhbY2fTGzpW64T6yEOdHlIbhX1DX6yAz2gMZKfnpQL2aFqxh5ACFV9dONSTzuQzkqeXwFEARsMxGP3eTQSWMpwVhEcraSn1zOqMb3CRDeQpgasq0lv4HRFhbwalOifKarjEL/8=</Modulus>\r\n<Exponent>AQAB</Exponent>\r\n<P>8+4qCwbxpWFuJje/UURm06Uec+Mk6a7Ye9FGvzVlnh7dYK38GR+bnf8NsoMRW8IlJnipfvqqEs1qnhRAJ4j96Q==</P>\r\n<Q>1tnh1UK2FxeVSbTXrrvKlSKAWqkjaQwLB+OQeMM5Ii3ogH++91bmO0Ku8GA4qE+r/KfypT4nECQID7i5ykkFpw==</Q>\r\n<DP>XTEqYtgeTf6xJGy77QJi/ozg24l2OskP8A3+J2LxFb3Y+ey+maKXw38D7qVgZlv/8Xi72MVPYKuWBhraf8A4sQ==</DP>\r\n<DQ>xBAk9FZikQQmahKr2HrqzdmkRBehhtVEo7hZOLr+wmAeklUBUfltNJsPxbApQ/8gtfoVhhIH18Tpzl8GvMCSdQ==</DQ>\r\n<InverseQ>889tPhprihee8OsPUN7Zyf1nH3tNK4uFiGmBCR1l/JMjbK62+wcQxssD7in8dZFzf/hUXZQl++DtiBUtc4O5Tw==</InverseQ>\r\n<D>ZNm0R12GZ17KhBtEzkNl1cW737DKH1MY3GK4GxQsKRszjx09Roba+B7+3rn6HtenghE733DVchyY69w6wQu0mj6fqZ/1ZqvmP0YH1d8otVjG2E6XhshYCJhZ7Ci0Z4n6UZwAG3NBDCtXAqNSUQY7NjPnTfcG5EkQ/nqlFJKdKLE=</D>\r\n</RSAKeyValue>\r\n");
            byte[] bytes = Encoding.UTF8.GetBytes(string_2);
            string text = Convert.ToBase64String(rsacryptoServiceProvider.SignData(bytes, new SHA1CryptoServiceProvider()));
            return string.Concat(new string[]
            {
            "<activationresponse>\r\n",
            string_2,
            "\r\n<signature>\r\n",
            text,
            "\r\n</signature>\r\n</activationresponse>\r\n"
            });
        }

        
        public static string smethod_1(string string_2, string string_3, int int_0)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(string_2);
            XmlWriterSettings xmlWriterSettings = Class4.xslCompiledTransform_0.OutputSettings.Clone();
            xmlWriterSettings.NewLineChars = "\r\n";
            xmlWriterSettings.NewLineHandling = NewLineHandling.Replace;
            StringBuilder stringBuilder = new StringBuilder();
            XmlWriter results = XmlWriter.Create(stringBuilder, xmlWriterSettings);
            XsltArgumentList xsltArgumentList = new XsltArgumentList();
            xsltArgumentList.AddParam("version", "", 3);
            xsltArgumentList.AddParam("edition", "", string_3);
            xsltArgumentList.AddParam("userspurchased", "", int_0);
            Class4.xslCompiledTransform_0.Transform(xmlDocument, xsltArgumentList, results);
            string string_4 = stringBuilder.ToString();
            return Class4.smethod_0(string_4);
        }

       
        private const string string_0 = "\r\n<RSAKeyValue>\r\n<Modulus>zLizNmLUd4VlIWee1GXgn/KxEwcghPASQ+NUzZhbY2fTGzpW64T6yEOdHlIbhX1DX6yAz2gMZKfnpQL2aFqxh5ACFV9dONSTzuQzkqeXwFEARsMxGP3eTQSWMpwVhEcraSn1zOqMb3CRDeQpgasq0lv4HRFhbwalOifKarjEL/8=</Modulus>\r\n<Exponent>AQAB</Exponent>\r\n<P>8+4qCwbxpWFuJje/UURm06Uec+Mk6a7Ye9FGvzVlnh7dYK38GR+bnf8NsoMRW8IlJnipfvqqEs1qnhRAJ4j96Q==</P>\r\n<Q>1tnh1UK2FxeVSbTXrrvKlSKAWqkjaQwLB+OQeMM5Ii3ogH++91bmO0Ku8GA4qE+r/KfypT4nECQID7i5ykkFpw==</Q>\r\n<DP>XTEqYtgeTf6xJGy77QJi/ozg24l2OskP8A3+J2LxFb3Y+ey+maKXw38D7qVgZlv/8Xi72MVPYKuWBhraf8A4sQ==</DP>\r\n<DQ>xBAk9FZikQQmahKr2HrqzdmkRBehhtVEo7hZOLr+wmAeklUBUfltNJsPxbApQ/8gtfoVhhIH18Tpzl8GvMCSdQ==</DQ>\r\n<InverseQ>889tPhprihee8OsPUN7Zyf1nH3tNK4uFiGmBCR1l/JMjbK62+wcQxssD7in8dZFzf/hUXZQl++DtiBUtc4O5Tw==</InverseQ>\r\n<D>ZNm0R12GZ17KhBtEzkNl1cW737DKH1MY3GK4GxQsKRszjx09Roba+B7+3rn6HtenghE733DVchyY69w6wQu0mj6fqZ/1ZqvmP0YH1d8otVjG2E6XhshYCJhZ7Ci0Z4n6UZwAG3NBDCtXAqNSUQY7NjPnTfcG5EkQ/nqlFJKdKLE=</D>\r\n</RSAKeyValue>\r\n";

        
        private const string string_1 = "<?xml version='1.0' encoding='utf-8'?>\r<xsl:stylesheet version='1.0' xmlns:xsl='http://www.w3.org/1999/XSL/Transform' xmlns:msxsl='urn:schemas-microsoft-com:xslt' exclude-result-prefixes='msxsl'>\r  <xsl:output method='xml' indent='no' omit-xml-declaration='yes'/>\r  <xsl:param name='edition'/>\r  <xsl:param name='version'/>\r  <xsl:param name='userspurchased'/>\r  \r  <xsl:template match='activationrequest'>\r    <data>\r      <xsl:text>\r</xsl:text>\r      <xsl:apply-templates/>\r      <edition><xsl:value-of select='$edition'/></edition>\r      <xsl:text>\r</xsl:text>\r      <version><xsl:value-of select='$version'/></version>\r      <xsl:text>\r</xsl:text>\r      <userspurchased><xsl:value-of select='$userspurchased'/></userspurchased>\r      <xsl:text>\r</xsl:text>\r    </data>\r  </xsl:template>\r\r  <xsl:template match='machinehash'>\r    <machinehash>\r      <xsl:value-of select='text()'/>\r    </machinehash>\r    <xsl:text>\r</xsl:text>\r  </xsl:template>\r\r  <xsl:template match='productcode|majorversion|minorversion|serialnumber|session|edition|productname'>\r    <xsl:copy>\r      <xsl:value-of select='text()'/>\r    </xsl:copy>\r    <xsl:text>\r</xsl:text>\r  </xsl:template>\r\r  <xsl:template match='productcodes'>\r    <xsl:copy>\r      <xsl:text>\r</xsl:text>\r      <xsl:apply-templates />\r    </xsl:copy>\r    <xsl:text>\r</xsl:text>    \r  </xsl:template>\r\r  <xsl:template match='product'>\r    <xsl:copy>\r      <xsl:text>\r</xsl:text>\r      <xsl:apply-templates />\r    </xsl:copy>\r    <xsl:text>\r</xsl:text>\r  </xsl:template>\r\r  <xsl:template match='text()'/>\r</xsl:stylesheet>\r\n";

        
        private static XslCompiledTransform xslCompiledTransform_0;
    }
}
