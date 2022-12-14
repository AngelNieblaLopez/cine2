using Domain.Models;
using Infrastructure.DataAccess.DTO;
using Infrastructure.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.WinForm.Forms.Sells
{
    public partial class FormMainSells : Form
    {
        private TaquilaModel taquillaModel = new TaquilaModel();
        private List<int> selectedSeatsId = new List<int>();

        public FormMainSells()
        {
            InitializeComponent();
        }

        private void FormMainSells_Load(object sender, EventArgs e)
        {
            loadComboBoxBillboard();
        }

        private void comboBoxBillboard_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedValue = (comboBoxBillboard.SelectedItem as dynamic).Value;
            loadComboBoxSchedule(selectedValue);
            LoadComboBoxAvaliableSeats(selectedValue);
        }

        private void comboBoxSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedValue = (comboBoxSchedule.SelectedItem as dynamic).Value;
            loadRoomName(selectedValue);
        }

        private void txtBoxCantBoletos_TextChanged(object sender, EventArgs e)
        {
            string TextIn = txtBoxCantBoletos.Text;
            bool canConvert = int.TryParse(TextIn, out int cantidadVertices);

            if (canConvert == false && TextIn != "")
            {
                MessageBox.Show("El valor introducido no es un número");
            }
            else
            {
                txtBoxCantBoletos.Text = "";
            }
        }

        private void loadRoomName(int pFunctionId)
        {
            string roomName = taquillaModel.getNameRoomByFunctionId(pFunctionId);
            txtBoxRoom.Text = roomName;
        }

        private void loadComboBoxSchedule(int pFunctionId)
        {
            var scheduleOfMovie = taquillaModel.getScheduleOfMovie(pFunctionId);

            List<ComboBoxDTO> items = new List<ComboBoxDTO>();
            ComboBoxDTO comboBoxDTO;

            foreach (var scheduleOfMovieItem in scheduleOfMovie)
            {
                comboBoxDTO = new ComboBoxDTO()
                {
                    Text = scheduleOfMovieItem.startsAt.Date.ToString(),
                    Value = scheduleOfMovieItem.id
                };

                items.Add(comboBoxDTO);
            }

            comboBoxSchedule.DisplayMember = "Text";
            comboBoxSchedule.ValueMember = "Value";


            comboBoxSchedule.DataSource = items;
        }

        private void loadComboBoxBillboard()
        {
            var avalilableMovies = taquillaModel.getAllAvailableMovies();

            List<ComboBoxDTO> items = new List<ComboBoxDTO>();

            ComboBoxDTO comboBoxDTO;
            foreach (var avalilableMovie in avalilableMovies)
            {
                comboBoxDTO = new ComboBoxDTO()
                {
                    Text = avalilableMovie.name,
                    Value = avalilableMovie.id
                };

                items.Add(comboBoxDTO);
            }

            comboBoxBillboard.DisplayMember = "Text";
            comboBoxBillboard.ValueMember = "Value";


            comboBoxBillboard.DataSource = items;
        }

        private void LoadComboBoxAvaliableSeats(int pFunctionId)
        {
            var avaliableSeats = taquillaModel.GetAllAvailableSeatsByFunction(pFunctionId);


            List<ComboBoxDTO> items = new List<ComboBoxDTO>();

            ComboBoxDTO comboBoxDTO;
            foreach (var avalilableSeat in avaliableSeats)
            {
                comboBoxDTO = new ComboBoxDTO()
                {
                    Text = $"{avalilableSeat.column} - {avalilableSeat.row}",
                    Value = avalilableSeat.id
                };

                items.Add(comboBoxDTO);
            }
            
            comboBoxSeats.DisplayMember = "Text";
            comboBoxSeats.ValueMember = "Value";

            comboBoxSeats.DataSource = items;
        }

        private void btnAddSeat_Click(object sender, EventArgs e)
        {
            int selectedSeatId = (comboBoxSeats.SelectedItem as dynamic).Value;

           int ActuallySelectedSeat = selectedSeatsId.Find(seatId => seatId == selectedSeatId);



            if (ActuallySelectedSeat == 0)
                selectedSeatsId.Add(selectedSeatId);
            else
                selectedSeatsId.Remove(selectedSeatId);


            txtBoxAsientosSeleccionados.Clear();
            foreach (ComboBoxDTO combo in comboBoxSeats.Items)
            {
                    ActuallySelectedSeat = selectedSeatsId.Find(seatId => seatId == selectedSeatId);
                if (ActuallySelectedSeat != 0)
                    txtBoxAsientosSeleccionados.Text += combo.Text + ", ";
            }

                
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Console.WriteLine(

            (comboBoxBillboard.SelectedItem as dynamic).Value
                );

        }

        
    }
}
