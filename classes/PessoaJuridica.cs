namespace ATIVIDADEBECKEND.classes
{
    public class PessoaJuridica : Pessoa
    {
        public string? CNPJ {get;set;}

        public void Inserir(PessoaJuridica pj)
        {
            using(StreamWriter escritor = new StreamWriter(pj.Nome+".txt"))
            {
                escritor.WriteLine($"{pj.Nome};R${pj.Rendimento};{pj.CNPJ}");
            }
        }
    }
}