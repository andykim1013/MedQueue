using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("로그인", "로그인 버튼이 클릭되었습니다.", "확인");
        }

        private void OnSearchButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("검색", "검색 버튼이 클릭되었습니다.", "확인");
        }
    }
}