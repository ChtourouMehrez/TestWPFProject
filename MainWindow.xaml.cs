using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private const int StepSize = 30; // Taille du déplacement en pixels
        private const int MaxPosition = 450; // Hauteur maximale pour le pointeur en pixels
        private const int MinPosition = 0;   // Position minimale pour le pointeur
        private int currentPosition = 106;   // Position initiale

        public MainWindow()
        {
            InitializeComponent();
        }

        // Méthode pour déplacer le rectangle vers le haut
        private void UpButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentPosition > MinPosition)
            {
                currentPosition -= StepSize; // Monter le pointeur
                Canvas.SetTop(PointerContainer, currentPosition); // Déplacer le conteneur (Grid)
                UpdatePointerText();
            }
        }

        // Méthode pour déplacer le rectangle vers le bas
        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentPosition < MaxPosition)
            {
                currentPosition += StepSize; // Descendre le pointeur
                Canvas.SetTop(PointerContainer, currentPosition); // Déplacer le conteneur (Grid)
                UpdatePointerText();
            }
        }

        // Mettre à jour le texte du pointeur (affiche la position en µm)
        private void UpdatePointerText()
        {
            int microns = (450 - currentPosition) / StepSize; // Conversion de la position en µm
            PointerText.Text = $"{microns} µm"; // Mettre à jour le texte
        }
    }
}
