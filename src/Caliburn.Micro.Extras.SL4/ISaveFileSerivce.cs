﻿namespace Caliburn.Micro.Extras {
    using System.IO;

    /// <summary>
    /// Interface for the Save File service.
    /// </summary>
    public interface ISaveFileSerivce {
        /// <summary>
        /// Gets or sets the default file name extension applied to files that are saved.
        /// </summary>
        string DefaultExt { get; set; }

        /// <summary>
        /// Gets or sets a filter string that specifies the files types and descriptions to display.
        /// </summary>
        string Filter { get; set; }

        /// <summary>
        /// Gets the file name for the selected file.
        /// </summary>
        string SafeFileName { get; }

        /// <summary>
        /// Determines the filename of the file what will be used.
        /// </summary>
        /// <returns><c>true</c> if a file is selected; otherwise <c>false</c>.</returns>
        bool DetermineFile();

        /// <summary>
        /// Opens the file specified by the <see cref="SafeFileName"/> property.
        /// </summary>
        /// <returns>A read-write stream for the file.</returns>
        Stream OpenFile();
    }
}
