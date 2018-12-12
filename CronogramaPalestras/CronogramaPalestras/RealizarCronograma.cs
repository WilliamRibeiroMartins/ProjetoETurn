using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CronogramaPalestras
{
    class RealizarCronograma
    {
        private readonly static int TempoAntesAlmoco = 180; //min
        private readonly static int TempoAposAlmoco = 240;

        IEnumerable<Palestra> Palestras { get; set; }

        public static void Cronograma(List<Palestra> palestras, ref string cronograma1, ref string cronograma2)
        {
            StringBuilder trilha1 = new StringBuilder();
            StringBuilder trilha2 = new StringBuilder();
            DateTime horaTrilha1 = new DateTime(2018, 12, 12, 9, 0, 0);
            DateTime horaTrilha2 = new DateTime(2018, 12, 12, 9, 0, 0);

            Palestra[] aux = new Palestra[100];
            palestras.CopyTo(aux);
            List<Palestra> listAux = aux.ToList();
            listAux.RemoveAll(x => x == null);

            AjustaCronograma(ref listAux, ref horaTrilha1, ref horaTrilha2, ref trilha1, ref trilha2, palestras, 0, 0);
            
            cronograma1 = trilha1.ToString();
            cronograma2 = trilha2.ToString();
        }

        public static void RemoverItensLista(ref List<Palestra> listaPalestras, string palestras)
        {
            foreach (var item in palestras.Split(';'))
                listaPalestras.RemoveAll(x => x.Nome.Equals(item, StringComparison.InvariantCultureIgnoreCase));
        }

        public static StringBuilder MontaCronograma(List<Palestra> palestras, ref DateTime horaTrilha, string[] palestrasAntesAlmoco, string[] palestrasDepoisAlmoco)
        {
            StringBuilder trilha = new StringBuilder();

            foreach (var palestra in palestras)
            {
                if (horaTrilha.Hour < 12)
                {
                    foreach (var item in palestrasAntesAlmoco)
                    {
                        if (palestra.Nome.Equals(item, StringComparison.InvariantCultureIgnoreCase))
                        {
                            trilha.AppendLine($"{horaTrilha.ToShortTimeString()} - {palestra.Nome} {palestra.Duracao}min");
                            horaTrilha = horaTrilha.AddMinutes(palestra.Duracao);
                        }
                    }
                }
            }
            foreach (var palestra in palestras)
            {
                if (!trilha.ToString().Contains("Almoço"))
                {
                    trilha.AppendLine($"{horaTrilha.ToShortTimeString()} - Almoço");
                    horaTrilha = horaTrilha.AddHours(1);
                }
                foreach (var item in palestrasDepoisAlmoco)
                {
                    if (palestra.Nome.Equals(item, StringComparison.InvariantCultureIgnoreCase))
                    {
                        trilha.AppendLine($"{horaTrilha.ToShortTimeString()} - {palestra.Nome} {palestra.Duracao}min");
                        horaTrilha = horaTrilha.AddMinutes(palestra.Duracao);
                    }
                }
            }
            trilha.AppendLine($"{horaTrilha.ToShortTimeString()} - Evento de Networking");

            return trilha;
        }

        public static void AjustaCronograma(ref List<Palestra> listAux, ref DateTime horaTrilha1, ref DateTime horaTrilha2, ref StringBuilder trilha1, ref StringBuilder trilha2, List<Palestra> palestras, int posicao1, int posicao2)
        {
            #region Trilha 1
            var trilha1AntesAlmoco = OterCombinacoes(listAux, TempoAntesAlmoco, string.Empty).ToList()[posicao1];
            RemoverItensLista(ref listAux, trilha1AntesAlmoco);

            var trilha1AposAlmoco = OterCombinacoes(listAux, TempoAposAlmoco, string.Empty).ToList()[posicao1];
            RemoverItensLista(ref listAux, trilha1AposAlmoco);

            trilha1 = MontaCronograma(palestras, ref horaTrilha1, trilha1AntesAlmoco.Split(';'), trilha1AposAlmoco.Split(';'));
            #endregion

            #region Trilha 2
            var trilha2AntesAlmoco = OterCombinacoes(listAux, TempoAntesAlmoco, string.Empty).ToList()[posicao2];
            RemoverItensLista(ref listAux, trilha2AntesAlmoco);

            var trilha2AposAlmoco = OterCombinacoes(listAux, TempoAposAlmoco, string.Empty).ToList()[posicao2];
            RemoverItensLista(ref listAux, trilha2AposAlmoco);

            trilha2 = MontaCronograma(palestras, ref horaTrilha2, trilha2AntesAlmoco.Split(';'), trilha2AposAlmoco.Split(';'));
            #endregion
        }

        public static IEnumerable<string> OterCombinacoes(List<Palestra> dados, decimal tempoTotal, string values)
        {
            for (int i = 0; i < dados.Count; i++)
            {
                decimal resto = tempoTotal - dados[i].Duracao;
                string vals = dados[i].Nome + ";" + values;

                if (resto == 0)
                {
                    yield return vals;
                }
                else
                {
                    List<Palestra> dadosPossiveis = dados.Take(i).Where(n => n.Duracao <= tempoTotal).ToList();

                    if (dadosPossiveis.Count > 0)
                    {
                        foreach (string s in OterCombinacoes(dadosPossiveis, resto, vals))
                        {
                            yield return s;
                        }
                    }
                } //else
            } //for
        } //method
    }
}
