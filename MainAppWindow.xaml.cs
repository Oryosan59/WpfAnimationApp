using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace WpfAnimationApp
{
    public partial class MainAppWindow : Window
    {
        public MainAppWindow()
        {
            InitializeComponent();
            Loaded += MainAppWindow_Loaded;
        }

        private void MainAppWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // フェードインアニメーションを開始
            var fadeInStoryboard = (Storyboard)FindResource("FadeInStoryboard");
            fadeInStoryboard.Begin();

            // 少し遅延してサイドパネルのスライドアニメーションを開始
            var slidePanelStoryboard = (Storyboard)FindResource("SlidePanelStoryboard");
            slidePanelStoryboard.BeginTime = TimeSpan.FromSeconds(0.3);
            slidePanelStoryboard.Begin();

            // コンテンツエリアのスケールアニメーションを開始
            var contentScaleStoryboard = (Storyboard)FindResource("ContentScaleStoryboard");
            contentScaleStoryboard.BeginTime = TimeSpan.FromSeconds(0.5);
            contentScaleStoryboard.Begin();
        }

        private void NavigationButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            MessageBox.Show($"{button.Content} が選択されました。", "ナビゲーション",
                          MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("アプリケーションを終了しますか？",
                                       "確認",
                                       MessageBoxButton.YesNo,
                                       MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}