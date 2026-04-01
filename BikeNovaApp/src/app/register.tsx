import { TextInput, KeyboardAvoidingView, Platform, ScrollView, StyleSheet, View, Text, Image, ImageBackground } from "react-native";
import { Button } from "@/components/button"
import { LinearGradient } from "expo-linear-gradient";
import { useAppFonts } from "@/hooks/useAppFonts"
import { Input } from "@/components/input";

export default function Register() {
    const isLoaded = useAppFonts()
    if (!isLoaded) {
        return null
    }
    return (
        <ImageBackground
            source={require("@/assets/background.png")}
            style={styles.background}
        >
        <KeyboardAvoidingView style={{ flex: 1 }} behavior={Platform.select({ ios: "padding", android: "height" })}>
            <ScrollView contentContainerStyle={{ flexGrow: 1 }}
                keyboardShouldPersistTaps="handled"
                showsVerticalScrollIndicator={false}
            >
                    <View style={styles.container}>
                        <Image
                            source={require("@/assets/Logo 1.png")}
                            style={styles.illustration}
                        />

                        <View style={styles.header}>
                            <Text style={styles.title}>Faça Login</Text>
                            <Text style={styles.subtitle}>Para começar a pedalar!</Text>
                        </View>

                        <View>
                            <Text style={styles.fieldNames}>E-mail</Text>
                            <TextInput style={styles.input}
                                placeholder="digite seu e-mail"
                                placeholderTextColor={"#FFFFFF80"}
                            />
                            <Text style={styles.fieldNames}>Senha</Text>
                            <TextInput style={styles.input}
                                placeholder="digite sua senha"
                                placeholderTextColor={"#FFFFFF80"} />
                            <Button label="Login"></Button>
                        </View>

                        <Text style={styles.linksText}>Ou use suas redes sociais</Text>
                        <View style={styles.iconsContainer}>
                            <Image style={styles.icons} source={require("@/assets/6b902610013a9c11fa62fab7fec58a4d2a35c9f2.png")} />
                            <Image style={styles.icons} source={require("@/assets/45232545b8031b683125636e836bfae7b4c475d1.png")} />
                            <Image style={styles.icons} source={require("@/assets/e149ce0e9fea86f1ab6cfcdeae71313e63c44dea.png")} />
                        </View>

                    </View>
            </ScrollView>
        </KeyboardAvoidingView>
        </ImageBackground>
    )



}

const styles = StyleSheet.create({
    background: {
        flex: 1,
        resizeMode: "cover"
    },
    container: {
        flex: 1,
        alignItems: "center",
        padding: 32,
        justifyContent: "center"
    },
    illustration: {
        width: "100%",
        height: 330,
        resizeMode: "contain",
    },
    header: {
        width: 318,
    },
    title: {
        fontFamily: "Roboto_700Bold",
        color: "#FFFFFF",
        fontSize: 36,
        textAlign: "left",
        marginBottom: 8
    },
    subtitle: {
        fontFamily: "Roboto_400Regular",
        color: "#FFFFFF",
        fontSize: 16,
        marginBottom: 46,
        textAlign: "left"
    },

    linksText: {
        fontFamily: "Roboto_400Regular",
        color: "#FFFFFF",
        fontSize: 16,
        marginBottom: 34,
        marginTop: 30
    },
    fieldNames: {
        fontFamily: "Roboto_400Regular",
        color: "#FFFFFF",
        fontSize: 16,
        marginBottom: 20,
    },
    input: {
        color: "#FFFFFF",
        backgroundColor: "#CA3C17",
        borderColor: "#F57857",
        borderWidth: 3,
        borderRadius: 12,
        height: 44,
        width: 318,
        paddingLeft: 24,
        marginBottom: 24
    },
    icons: {
        width: 36,
        height: 36,
    },
    iconsContainer: {
        flexDirection: "row",
        gap: 16
    },
})