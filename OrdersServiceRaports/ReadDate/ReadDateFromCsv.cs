using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace OrdersServiceRaports.ReadDate
{
    public static class ReadDateFromCsv
    {
        #region Pola
        /// <summary>
        /// Pole przyjmuje komunikaty dotyczące odczytu danych z pliku
        /// </summary>
        public static string message = null;
        #endregion

        #region Metody
        /// <summary>
        /// Metoda odczytująca pojedyńcze linie z pliku Csv z pominięciem pierwszej,
        /// która jest nagłówkiem.
        /// Wywołująca metodę <see cref="CsvToList(List{string})"/>
        /// </summary>
        /// <param name="filePath">Ścieżka do pliku.</param>       
        public static void ReadFileCsv(string filePath)
        {
            List<string> readDate = new List<string>();

            try
            {
                StreamReader streamReader = File.OpenText(filePath);
                string textLine = streamReader.ReadLine();
                do
                {
                    textLine = streamReader.ReadLine();
                    if (textLine == null) break;
                    readDate.Add(textLine);
                } while (textLine != null);

                streamReader.Close();
            }
            catch (Exception)
            {
                throw new ArgumentNullException("Brak ścieżki do pliku");
            }
            CsvToList(readDate);
        }
        /// <summary>
        /// Metoda sprawdzająca czu odczytane dane z pliku mają odpowiedni
        /// format, jesli tak to zapisuje je do listy z zamówieniami
        /// Metoda zapisuje również do <see cref="message"/> komunikaty o błędach
        /// </summary>
        /// <param name="readDate"> lista z odczytanymi danymi z pliku.</param>
        private static void CsvToList(List<string> readDate)
        {
            message = null;

            foreach (var item in readDate)
            {
                String[] orderDetails = item.Split(',');
                try
                {
                    Order order = new Order(orderDetails[0], ulong.Parse(orderDetails[1]), orderDetails[2],
                       uint.Parse(orderDetails[3]), Double.Parse(orderDetails[4], CultureInfo.InvariantCulture));
                    order.OrdersAdd(order);
                }
                catch (FormatException fe)
                {
                    message = message + fe.Message + " *** Błąd w linii: " + item.ToString() + "***" + "\n";

                }
                catch (Exception e)
                {
                    message = message + e.Message + " *** Błąd w linii: " + item.ToString() + "***" + "\n";
                }
            }
        }
        #endregion
    }
}
