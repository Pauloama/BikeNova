import { View, Text, StyleSheet, Image, ScrollView, KeyboardAvoidingView, Platform, Alert } from "react-native"
import { Link } from "expo-router"
import { Input } from "@/components/input"
import { useAppFonts } from "@/hooks/useAppFonts"
import { Button } from "@/components/button"
import { LinearGradient } from "expo-linear-gradient"

export default function Index() {
    const isLoaded = useAppFonts()
    return (
        <KeyboardAvoidingView style = {{flex: 1}} behavior={Platform.select({ios: "padding", android: "height"})}>
            <ScrollView contentContainerStyle = {{flexGrow: 1}} 
            keyboardShouldPersistTaps="handled"
            showsVerticalScrollIndicator={false}
            >
                <View style={styles.container}>
                    <LinearGradient
                    colors={["#0B80D9", "#264F6F"]}

                    />
                    <Image
                        source={require("@/assets/Logo 1.png")}
                        style={styles.illustration}
                    />
                    <Text style={styles.subtitle}>
                        O seu aplicativo para pedalar em Venda Nova!
                    </Text>
                    <View>
                        <Text style={styles.footerText}>
                            Não tem uma conta? Cadastre-se aqui.
                        </Text>
                    </View>
                </View>
            </ScrollView>
        </KeyboardAvoidingView>

    )
}

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: "#004D88",
        padding: 32
    },
    illustration: {
        width: "100%",
        height: 330,
        resizeMode: "contain",
        marginTop: 62,
    },
    title: {
        fontSize: 16,
        fontWeight: 400,
        fontFamily: "Roboto_400Regular",
        textAlign: "center",
        justifyContent: "center"

    },
    subtitle: {
        fontSize: 16,
        fontFamily: "Roboto_400Regular",
        color: "#FFFFFF",
        textAlign: "center",
        justifyContent: "center"
    },
    form: {
        marginTop: 24,
        gap: 12
    },
    footerText: {
        textAlign: "center",
        marginTop: 24,
        color: "#585860"
    },
    footerLink: {
        color: "#4F6CF3",
        fontWeight: 700
    }
})