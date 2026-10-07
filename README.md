# Industrial Vision Grading System

A C#-based industrial computer vision system for tobacco leaf grading using RGB/LAB color analysis, image processing, and multi-source image data.

## Overview

This project focuses on developing and improving an industrial computer vision system for automatic tobacco leaf grading.

The system processes captured leaf images, applies image filtering and color-space analysis, and uses color-based classification logic to distinguish between different tobacco leaf grades.

The project was developed based on an existing research prototype, with substantial development and improvement focused on LAB-based color segmentation, image-processing algorithms, classification logic, and the Windows Forms user interface.

The available image data included visible-light images as well as a set of images captured using an infrared camera. The main grading experiments and algorithm improvements described below focused primarily on visible-light color images.

## How It Works

The main vision-processing pipeline is:

**Image Input → Image Filtering → Color-Space Conversion → Color Segmentation → Feature / Threshold Analysis → Grade Classification**

The system was implemented as a C# Windows Forms application, allowing users to load images, apply different image-processing operations, inspect processed results, and perform tobacco leaf grading.

## My Contribution

My main contributions included:

- Implementing **LAB color-space segmentation** to improve discrimination between visually similar tobacco leaf grades
- Developing and modifying the **grading and classification logic**
- Implementing and adjusting multiple **image-processing and filtering operations**
- Developing parts of the **C# Windows Forms user interface**
- Testing different image-processing and color-analysis approaches
- Analyzing classification errors and iteratively improving the processing pipeline
- Integrating the improved algorithms into the existing vision application

## Tech Stack

- **C#**
- **.NET / Windows Forms**
- **Emgu CV / OpenCV**
- **RGB and LAB color spaces**
- **Image filtering**
- **Color segmentation**
- **Image processing**
- **Computer vision**

## Testing and Iteration

### Initial Approach

The initial grading approach relied primarily on **RGB-based color classification**.

One of the main challenges was that tobacco leaves from different grades could have very similar colors. Under ordinary imaging conditions, these subtle differences were difficult to distinguish reliably.

The initial system achieved a classification accuracy of approximately **70%**.

### Problem Identified

Testing showed that relying primarily on RGB information was not sufficient to reliably distinguish some visually similar leaf grades.

Image acquisition conditions also had a significant impact on classification. In particular, appropriate and controlled illumination was important for making subtle color differences between samples more distinguishable.

### Iteration and Improvement

To improve the system, I introduced **LAB color-space segmentation** and modified parts of the image-processing and classification algorithms.

Compared with relying primarily on RGB values, LAB provided an additional representation of color information that helped distinguish samples with subtle visual differences.

The processing and classification logic was also adjusted based on observed errors during testing.

### Result

After introducing LAB-based segmentation and optimizing the image-processing and classification logic under appropriate imaging conditions, the classification accuracy improved from approximately:

**70% → 85%**

## What I Learned

This project gave me practical experience in improving a real computer vision system through iterative testing rather than relying on a single algorithm.

A key lesson was that the performance of an applied vision system depends not only on the classification method itself, but also on factors such as **image acquisition conditions, illumination, color representation, preprocessing, filtering, and classification logic**.

It also strengthened my experience in taking an existing technical prototype, identifying its limitations, implementing improvements, testing the results, and integrating those improvements into a usable software system.

## Source Code

This repository contains the C# Windows Forms source code and Visual Studio solution for the project.

The project was originally developed in an older Windows/software environment. The source code is preserved here as a project example, although running the application may require recreating the original development environment and dependencies.
