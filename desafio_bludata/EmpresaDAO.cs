using System;

public class EmpresaDAO
{
	public int idEmpresa;
	public string nomeEmpresa;
	public string cnpj;
	public string uf;

	public EmpresaDAO()
	{
	}

	public override string ToString()
	{
		return nomeEmpresa;
	}
}
