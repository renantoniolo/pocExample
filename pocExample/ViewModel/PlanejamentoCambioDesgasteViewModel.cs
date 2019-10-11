using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using pocExample.Model;

namespace pocExample.ViewModel
{
    public class PlanejamentoCambioDesgasteViewModel : ViewModelBase
    {
        public PlanejamentoCambioDesgasteViewModel()
        {
            Gaiolas = new ObservableCollection<Gaiola>();

        }

        public string ValueMoc { get; set; } = "100,00";

        public ObservableCollection<Gaiola> Gaiolas { get; }


        internal void ThisOnAppearing()
        {
            Gaiolas.Add(new Gaiola()
            {
                Id = 1,

                CodGuiaEntrada = "SR12-01",

                CodGuiaSaida = "SR12-01",

                TonMax = 154000,

                TonMin = 1200,

                Canal01 = 134566,

                Canal02 = 145678,

                Canal03 = 129897,

                Canal04 = 178865,

                Canal05 = 139987,

                Canal06 = 118765,

                TotalToneladas1 = 1236548,

                TotalToneladas2 = 121534,

                TotalToneladas3 = 1240357,

                TotalToneladas4 = 1236548

            });

            Gaiolas.Add(new Gaiola()
            {
                Id = 2,

                CodGuiaEntrada = "SR12-01",

                CodGuiaSaida = "SR12-01",

                TonMax = 154000,

                TonMin = 1200,

                Canal01 = 134566,

                Canal02 = 145678,

                Canal03 = 129897,

                Canal04 = 178865,

                Canal05 = 139987,

                Canal06 = 118765,

                TotalToneladas1 = 1236548,

                TotalToneladas2 = 121534,

                TotalToneladas3 = 1240357,

                TotalToneladas4 = 1236548

            });

            Gaiolas.Add(new Gaiola()
            {
                Id = 3,

                CodGuiaEntrada = "SR12-01",

                CodGuiaSaida = "SR12-01",

                TonMax = 154000,

                TonMin = 1200,

                Canal01 = 134566,

                Canal02 = 145678,

                Canal03 = 129897,

                Canal04 = 178865,

                Canal05 = 139987,

                Canal06 = 118765,

                TotalToneladas1 = 1236548,

                TotalToneladas2 = 121534,

                TotalToneladas3 = 1240357,

                TotalToneladas4 = 1236548

            });
        }
    }
}
