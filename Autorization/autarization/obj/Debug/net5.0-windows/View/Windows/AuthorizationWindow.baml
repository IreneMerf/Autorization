   M S B A M L   `   `   `  ????G  Cautarization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:autarization.View.Windowsautarization.View.Windows  5   	   ?$clr-namespace:autarization.ViewModelautarization.ViewModel  5   	   ?$clr-namespace:autarization.ViewModelautarization.ViewModel  5
   S   3    -autarization.View.Windows.AuthorizationWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:autarization.View.Windows     5   	   :	viewmodel$clr-namespace:autarization.ViewModel     5   	   _ [MaterialDesignThemes.Wpf, Version=4.6.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   
   5
viewmodel1$clr-namespace:autarization.ViewModel  6S     ? Title$%  Окно авторизации??5   	   $	??300??6"   $	??300??6/    ? WindowStartupLocation$ CenterScreen=?6;    ? DataContext 5      3   -autarization.ViewModel.AuthorizationVIewModel  5   
   .??5      ? .+?5   
   ? 
???????$??2??6"    ? RowDefinitions 5      ?? 5      $??* ?6    ?? 5      $??60 ?6    .+?5      ?? $??15q?6   $??Center=?6%   .+?5      ?? $ ??Введите логин:??6   ?? 5      -   5         ??Name$ tbLogin??5      ?? 5      $"??Введите пароль:??6   G? 5      -   5         G?Name$ 
tbPassword??5      5      ?? 5      -   5         ??Name$ 	btnSingin??5      $??1??5      $??
Войти??5       
??? ??? ? Cursor$
 Hand??5#      $
??Left=?5$      $??15q?6,   $??84??68   5'      5(      5*      