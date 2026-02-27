import {
    useFonts,
    Roboto_400Regular,
    Roboto_700Bold,
    Roboto_400Regular_Italic
} from "@expo-google-fonts/roboto";

export const useAppFonts = () => {
    const [fontsLoaded] = useFonts({
        Roboto_400Regular,
        Roboto_700Bold,
        Roboto_400Regular_Italic
    });

    return fontsLoaded;
}