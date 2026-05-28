namespace Test.src.DesignPatterns.Behavioral.Memento
{
    public class EditorState
    {
        private readonly string _title;
        private readonly string _content;

        public EditorState(string title, string content)
        {
            _title = title;
            _content = content;
        }

        public EditorState CreateState(Editor editor)
        {
            return new EditorState(editor.Title, editor.Content);
        }

        public void Restore(Editor editor)
        {
            editor.Title = _title;
            editor.Content = _content;
        }
    }
}