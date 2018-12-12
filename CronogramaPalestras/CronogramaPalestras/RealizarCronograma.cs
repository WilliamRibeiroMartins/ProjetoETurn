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

		public string Cronograma(List<Palestra> palestras)
		{
			var diaUm = new List<Palestra>();
			var diaDois = new List<Palestra>();
			List<Palestra> listAux;

			var testeTempoAntesAlmoco = OterCombinacoes(palestras, TempoAntesAlmoco, string.Empty);
			var testeTempoAposAlmoco = OterCombinacoes(palestras, TempoAposAlmoco, string.Empty);

			/*
			for (int i = 0; i < palestras.Count; i++)
			{
				listAux = palestras.Where(x => x.Duracao == palestras[i].Duracao).ToList();

				int quantAux = Convert.ToInt16(listAux.Count() / 2);

				for (int ii = 0; ii < listAux.Count(); ii++)
				{
					if (ii < quantAux)
						diaUm.Add(listAux[ii]);
					else
						diaDois.Add(listAux[ii]);
				}
				i += listAux.Count();
			}

			// ---------------------------------------------------------------------------------

			List<int> posicoes = new List<int>();

			for (int i = 0; i < palestras.Count; i++)
			{
				listAux = palestras.Where(x => x.Duracao == palestras[i].Duracao).ToList();
				int duracao = 0;

				duracao += listAux.First().Duracao;
				if (duracao == TempoAntesAlmoco)
				{

				}
				else if (duracao < TempoAntesAlmoco)
				{

				}
				else if (duracao > TempoAntesAlmoco)
				{

				}

				i += listAux.Count();
			}
			*/

			return string.Empty;
		}



		public IEnumerable<string> OterCombinacoes(List<Palestra> dados, decimal tempoTotal, string values)
		{
			for (int i = 0; i < dados.Count; i++)
			{
				decimal resto = tempoTotal - dados[i].Duracao;
				string vals = dados[i].Nome + "," + values;

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
