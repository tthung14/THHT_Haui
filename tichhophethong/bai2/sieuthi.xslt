<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
		<html>
			<head>
				<title>Siêu thi điện máy</title>
			</head>
			<body>
				<h2>
					Siêu thị: <xsl:value-of select="SieuThi/TenSieuThi"/>
				</h2>
				<h3>
					Địa chỉ: <xsl:value-of select="SieuThi/DiaChi"/>
				</h3>
				<h3>
					Điện thoại: <xsl:value-of select="SieuThi/SoDienThoai"/>
				</h3>
				<h3>Danh sách các mặt hàng</h3>
				<table border="1" cellpadding="0">
					<tr>
						<td>STT</td>
						<td>Mã hàng</td>
						<td>Tên hàng</td>
						<td>Số lượng</td>
						<td>Loại hàng</td>
						<td>Đơn giá</td>
					</tr>
					<xsl:for-each select="SieuThi/Hang">
						<xsl:if test="SoLuong>10">
							<tr>
								<td>
									<xsl:value-of select="position()"/>
								</td>
								<td>
									<xsl:value-of select="@MaHang"/>
								</td>
								<td>
									<xsl:value-of select="TenHang"/>
								</td>
								<td>
									<xsl:value-of select="SoLuong"/>
								</td>
								<td>
									<xsl:value-of select="LoaiHang"/>
								</td>
								<td>
									<xsl:value-of select="DonGia"/>
								</td>
							</tr>
						</xsl:if>
					</xsl:for-each>
				</table>
			</body>
		</html>
    </xsl:template>
</xsl:stylesheet>
