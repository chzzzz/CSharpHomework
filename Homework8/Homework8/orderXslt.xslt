<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:output omit-xml-declaration="yes"/>
  <xsl:template match="/">
   <html>
    <body>
        <xsl:for-each select="ArrayOfOrder/Order"> 
          <h2>
            订单号：<xsl:value-of select="serialNumber"/>
          </h2>
          <h3>姓名：<xsl:value-of select="Name"/>></h3>
          <h3>
            电话号码：<xsl:value-of select="TellNu"/>
          </h3>>
          <h3>订单明细：</h3>
          <table border="1">
            <tr bgcolor="#9acd32">
              <th>名称</th>
              <th>价格</th>
              <th>数量</th>
            </tr>
          <xsl:for-each select="orderDetails/OrderDetails">
          <tr>  
            <td>  
              <xsl:value-of select="name"/>  
            </td>  
            <td>  
              <xsl:value-of select="eachPrice"/>  
            </td>  
            <td>  
              <xsl:value-of select="Nu"/>  
            </td>  
          </tr> 
          </xsl:for-each>
          </table>
        </xsl:for-each>
    </body>
  </html>
  </xsl:template>
</xsl:stylesheet>
