using System.Windows;
using PetManager.Models;
using PetManager.Services;

namespace PetManager;

public partial class MainWindow : Window
{
    private readonly PetService _petService;

    public MainWindow()
    {
        InitializeComponent();

        _petService = new PetService();
    }

    private void AddPet_Click(object sender, RoutedEventArgs e)
    {
        Pet pet = new Pet(
            NameBox.Text,
            SpeciesBox.Text,
            3
        );

        _petService.DisplayPet(pet);
    }
}