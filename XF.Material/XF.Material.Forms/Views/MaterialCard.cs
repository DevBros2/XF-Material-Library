﻿using Xamarin.Forms;
using XF.Material.Forms.Resources;

namespace XF.Material.Forms.Views
{
    /// <summary>
    /// A container that display content and actions on a single topic. 
    /// </summary>
    public class MaterialCard : Frame, IMaterialView
    {
        public static readonly BindableProperty ElevationProperty = BindableProperty.Create(nameof(Elevation), typeof(int), typeof(MaterialCard), 1);

        /// <summary>
        /// Gets or sets the virtual distance along the z-axis for emphasis.
        /// </summary>
        public int Elevation
        {
            get => (int)GetValue(ElevationProperty);
            set => SetValue(ElevationProperty, value);
        }

        /// <summary>
        /// Initializes a new instance of <see cref="MaterialCard"/>.
        /// </summary>
        public MaterialCard()
        {
            this.SetDynamicResource(BackgroundColorProperty, MaterialConstants.Color.SURFACE);
        }
    }
}
