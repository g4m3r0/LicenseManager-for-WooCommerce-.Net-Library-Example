# LicenseManager for WooCommerce .Net Library WinForms Example
An example WinForms projects to show how to use the C# Library for the [License Manager for WooCommerce](https://github.com/wpexpertsio/license-manager-woocommerce) formerly known as LicenseManager.at. The C# Library is avialable here: [LicenseManager for WooCommerce .Net Library](https://github.com/g4m3r0/LicenseManager-for-WooCommerce-.Net-Library).

# Code Examples
```c#
// Create a license manager (WordPress Host URL, Consumer API Key, Consumer API Secret)
var licenseManager = new("http://domain.com", "ck_3e68d6156f48ddb61b1748ca548f632b1d19d446", "cs_6a74509a3c4127bf19340ef873fd9349eca07g78");

// Activate a license key (this will increase the TimesActivated counter if successful)
var (success, errorMessage) = await _licenseManager.ActivateLicenseAsync(licenseKey, productId);

MessageBox.Show(success
                ? $"License {licenseKey} was successfully activated for product {productId}."
                : $"Something went wrong: {errorMessage}");
                
// Check if a license key is valid for a specific product
var (success, errorMessage) = await _licenseManager.ValidateLicenseAsync(licenseKey, productId);

MessageBox.Show(success
                ? $"License {licenseKey} was successfully validated for product {productId}."
                : $"Something went wrong: {errorMessage}");
```

# [LicenseManager for WooCommerce .Net Library](https://github.com/g4m3r0/LicenseManager-for-WooCommerce-.Net-Library)
