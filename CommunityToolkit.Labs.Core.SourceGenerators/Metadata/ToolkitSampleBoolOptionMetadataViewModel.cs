// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using CommunityToolkit.Labs.Core.SourceGenerators.Attributes;
using System.ComponentModel;

namespace CommunityToolkit.Labs.Core.SourceGenerators.Metadata
{
    /// <summary>
    /// An INPC-enabled metadata container for data defined in an <see cref="ToolkitSampleBoolOptionAttribute"/>.
    /// </summary>
    /// <remarks>
    /// Instances of these are generated by the <see cref="ToolkitSampleMetadataGenerator"/> and
    /// provided to the app alongside the sample registration.
    /// </remarks>
    public class ToolkitSampleBoolOptionMetadataViewModel : IGeneratedToolkitSampleOptionViewModel
    {
        private string _label;
        private string? _title;
        private object _value;

        /// <summary>
        /// Creates a new instance of <see cref="ToolkitSampleBoolOptionAttribute"/>.
        /// </summary>
        public ToolkitSampleBoolOptionMetadataViewModel(string id, string label, bool defaultState, string? title = null)
        {
            Name = id;
            _title = title;
            _label = label;
            _value = defaultState;
        }

        /// <inheritdoc cref="INotifyPropertyChanged.PropertyChanged"/>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// A unique identifier for this option.
        /// </summary>
        /// <remarks>
        /// Used by the sample system to match up <see cref="ToolkitSampleBoolOptionMetadataViewModel"/> to the original <see cref="ToolkitSampleBoolOptionAttribute"/> and the control that declared it.
        /// </remarks>
        public string Name { get; }

        /// <summary>
        /// The current boolean value.
        /// </summary>
        /// <remarks>
        /// Provided to accomodate binding to a property that is a non-nullable <see cref="bool"/>.
        /// </remarks>
        public bool BoolValue
        {
            get => (bool)_value;
            set
            {
                _value = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
            }
        }

        /// <inheritdoc/>
        public object? Value
        {
            get => BoolValue;
            set
            {
                BoolValue = (bool)(value ?? false);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
            }
        }

        /// <summary>
        /// A label to display along the boolean option.
        /// </summary>
        public string Label
        {
            get => _label;
            set
            {
                _label = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Label)));
            }
        }

        /// <summary>
        /// A title to display on top of the boolean option.
        /// </summary>
        public string? Title
        {
            get => _title;
            set
            {
                _title = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Title)));
            }
        }
    }
}