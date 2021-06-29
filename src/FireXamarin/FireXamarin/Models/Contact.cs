namespace FireXamarin.Models
{
    public class Contact : BaseModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }

        #region Internal_entitities
        private bool _isFirst;
        public bool IsFirst
        {
            get => _isFirst;
            set => SetProperty(ref _isFirst, value);
        }

        private bool _isLast;
        public bool IsLast
        {
            get => _isLast;
            set => SetProperty(ref _isLast, value);
        }
        #endregion

        public bool ValidatePropertiesRequired()
        {
            return !string.IsNullOrWhiteSpace(Id) &&
                   !string.IsNullOrWhiteSpace(Name) &&
                   !string.IsNullOrWhiteSpace(Phone);
        }
    }
}