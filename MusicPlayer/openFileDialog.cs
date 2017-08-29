using System.Windows.Forms;

namespace MusicPlayer
{
    internal class openFileDialog
    {
        public object Filename { get; internal set; }
        public string SelectedPath { get; internal set; }
        public DialogResult ShowDialog { get; internal set; }
    }
}