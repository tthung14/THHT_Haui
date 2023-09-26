<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
		<html>
			<table>
				<tr>
					<td colspan="2">BỆNH VIỆN ĐA KHOA</td>
					<th colspan="3">DANH SÁCH BỆNH NHÂN</th>
				</tr>
				<tr>
					<xsl:for-each select="BVDK/Khoa">
						<tr>
							<td colspan="2">
								Khoa: <xsl:value-of select="TenKhoa"/>
							</td>
							<td colspan="3">
								Phòng: <xsl:value-of select="Phong"/>
							</td>
						</tr>
						<tr>
							<table border="1" cellpadding="0">
								<tr>
									<td>Mã số BN</td>
									<td>Họ tên</td>
									<td>Ngày nhập viện</td>
									<td>Số ngày điều trị</td>
									<td>Số tiền phải trả</td>
								</tr>
								<xsl:for-each select="BenhNhan">
									<tr>
										<td>
											<xsl:value-of select="@MasoBN"/>
										</td>
										<td>
											<xsl:value-of select="HoTen"/>
										</td>
										<td>
											<xsl:value-of select="NgayNhapVien"/>
										</td>
										<td>
											<xsl:value-of select="NgayDieuTri"/>
										</td>
										<td>
											<xsl:value-of select="NgayDieuTri * 15000"/>
										</td>
									</tr>
								</xsl:for-each>
							</table>
						</tr>
					</xsl:for-each>
				</tr>
			</table>
		</html>
    </xsl:template>
</xsl:stylesheet>
