using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CronogramaPalestras
{
	class RealizarCronograma
	{
		private readonly int TempoAntesAlmoco = 180; //min
		private readonly int TempoAposAlmoco = 240;

		public static string Cronograma(List<Palestra> palestras)
		{
			var diaUm = new List<Palestra>();
			var diaDois = new List<Palestra>();
			List<Palestra> listAux;

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
			
			

			return string.Empty;
		}
	}
}
