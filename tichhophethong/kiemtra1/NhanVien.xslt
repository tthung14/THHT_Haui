<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
		<html>
			<head>
				
			</head>
			<body>
				<h2 align="center">BẢNG LƯƠNG THÁNG</h2>
				<table>
					<xsl:for-each select="DS/congty[@TenCT='Công ty dược Nam Hà']">
						<tr>
							<th>
								Tên công ty: 
							</th>
							<td><xsl:value-of select="@TenCT"/></td>
						</tr>
						<tr>
							<th>
								Tên phòng: 
							</th>
							<td>
								<xsl:value-of select="donvi/tendv"/>
							</td>
						</tr>
						<table border="1" cellpadding="0" width="100%">
							<tr>
								<th>STT</th>
								<th>Họ tên</th>
								<th>Ngày sinh</th>
								<th>Ngày công</th>
								<th>Lương</th>
							</tr>
							<xsl:for-each select="donvi/nhanvien">
								<tr>
									<td>
										<xsl:value-of select="position()"/>
									</td>
									<td>
										<xsl:value-of select="hoten"/>
									</td>
									<td>
										<xsl:value-of select="ngaysinh"/>
									</td>
									<td>
										<xsl:value-of select="ngaycong"/>
									</td>
									<td>
										<xsl:choose>
											<xsl:when test="ngaycong &lt;= 20">
												<xsl:value-of select="ngaycong * 150000"/>
											</xsl:when>
											<xsl:when test="ngaycong &lt;= 25">
												<xsl:value-of select="20 * 150000 + (ngaycong - 20) * 200000"/>
											</xsl:when>
											<xsl:otherwise>
												<xsl:value-of select="20 * 150000 + 5 * 200000 + (ngaycong - 25) * 250000"/>
											</xsl:otherwise>
										</xsl:choose>
									</td>
								</tr>
							</xsl:for-each>
						</table>
					</xsl:for-each>
				</table>
			</body>
		</html>
    </xsl:template>
</xsl:stylesheet>
