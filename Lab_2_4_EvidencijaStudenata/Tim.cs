using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_4_EvidencijaStudenata
{
    /// <summary>
    /// Klasa za definiranje podataka i funkcionalnosti tima studenata.
    /// </summary>
    public class Tim
    {
        #region Constructors

        #endregion

        #region Private Fields

        private int id;
        private string oznakaTima;
        private string nazivProjekta;
        private string opisProjekta;
        private string napomena;

        #endregion

        #region Properties

        /// <summary>
        /// Jedinstveni identifikator tima.
        /// </summary>
        public int Id
        {
            get
            {
                return id;
            }
            private set
            {
                if (id != value)
                {
                    id = value;
                }
            }
        }

        /// <summary>
        /// Jedinstvena oznaka tima.
        /// </summary>
        public string OznakaTima
        {
            get
            {
                return oznakaTima;
            }
            set
            {
                if (oznakaTima != value)
                {
                    oznakaTima = value;
                }
            }
        }

        /// <summary>
        /// Naziv projekta kojeg je tim odabrao.
        /// </summary>
        public string NazivProjekta
        {
            get
            {
                return nazivProjekta;
            }
            set
            {
                if (nazivProjekta != value)
                {
                    nazivProjekta = value;
                }
            }
        }

        /// <summary>
        /// Detaljan opis projekta kojeg je tim odabrao.
        /// </summary>
        public string OpisProjekta
        {
            get
            {
                return opisProjekta;
            }
            set
            {
                if (opisProjekta != value)
                {
                    opisProjekta = value;
                }
            }
        }

        /// <summary>
        /// Dodatne opcionalne napomene o timu i projektu.
        /// </summary>
        public string Napomena
        {
            get
            {
                return napomena;
            }
            set
            {
                if (napomena != value)
                {
                    napomena = value;
                }
            }
        }

        #endregion

        #region Methods

        #endregion
    }
}
