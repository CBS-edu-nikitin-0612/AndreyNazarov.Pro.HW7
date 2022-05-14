using System;
using System.Text;
using System.Windows;
using System.Reflection;

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonLoad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Assembly assembly = Assembly.LoadFrom(TextBoxPath.Text);
                StringBuilder stringBuilder = new($"Fullname: {assembly.FullName}\n\n");

                var types = assembly.GetTypes();
                foreach (var item in types)
                {
                    stringBuilder.Append("\tТип: " + item.FullName + "\n");
                    if (CheckBoxCnst.IsChecked == true)
                    {
                        stringBuilder.Append(GetConstructors(item));
                    }
                    if (CheckBoxFields.IsChecked == true)
                    {
                        stringBuilder.Append(GetFields(item));
                    }
                    if (CheckBoxMethods.IsChecked == true)
                    {
                        stringBuilder.Append(GetMethods(item));
                    }
                    if (CheckBoxAttributes.IsChecked == true)
                    {
                        stringBuilder.Append(GetAttributes(item));
                    }
                    stringBuilder.Append("\n");
                }
                TextBoxResult.Text = stringBuilder.ToString();
            }
            catch (Exception ex)
            {
                TextBoxResult.Text = ex.Message;
                return;
            }
        }

        private string GetConstructors(Type type)
        {
            StringBuilder stringBuilder = new("\t\tКонструкторы:\n");

            foreach (var item in type.GetConstructors())
            {
                stringBuilder.Append($"\t\tPublic: {item.IsPublic}\n");
                stringBuilder.Append($"\t\tStatic: {item.IsStatic}\n");
                stringBuilder.Append($"\t\tAbstract: {item.IsAbstract}\n");
                stringBuilder.Append($"\t\tVirtual: {item.IsVirtual}\n\n");
            }
            return stringBuilder.ToString();
        }

        private string GetFields(Type type)
        {
            StringBuilder stringBuilder = new("\t\tПоля:\n");
            foreach (var item in type.GetFields())
            {
                stringBuilder.Append($"\t\tField: {item.Name} \n");
                stringBuilder.Append($"\t\tStatic: {item.IsStatic} \n");
                stringBuilder.Append($"\t\tType: {item.DeclaringType} \n\n");
            }
            return stringBuilder.ToString();
        }
        private string GetMethods(Type type)
        {
            StringBuilder stringBuilder = new("\t\tМетоды:\n");
            foreach (var item in type.GetMethods())
            {
                stringBuilder.Append($"\t\tMethod: {item.Name} \n");
                stringBuilder.Append($"\t\tReturnType: {item.ReturnType} \n");
                stringBuilder.Append($"\t\tAttributes: {item.Attributes} \n");
                stringBuilder.Append($"\t\tStatic: {item.IsStatic} \n");
                stringBuilder.Append($"\t\tParameters: {GetParameters(item)} \n\n");
            }
            return stringBuilder.ToString();
        }

        private string GetAttributes(Type type)
        {
            StringBuilder stringBuilder = new("\t\tАтрибуты:\n");
            foreach (var item in type.GetCustomAttributes())
            {
                stringBuilder.Append($"\t\tAttribute: {item} \n");
            }
            return stringBuilder.ToString();
        }
        private string GetParameters(MethodInfo methodInfo)
        {
            StringBuilder stringBuilder = new();
            foreach (var item in methodInfo.GetParameters())
            {
                stringBuilder.Append($"{item.ParameterType} {item.Name} ,");
            }
            if (stringBuilder.Length > 2)
            {
                stringBuilder.Remove(stringBuilder.Length - 2, 2);
            }
            return stringBuilder.ToString();
        }
    }
}
