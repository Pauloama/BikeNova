import { View, Text, StyleSheet, Image, ScrollView, KeyboardAvoidingView, Platform } from "react-native"
import { Link } from "expo-router"

import { LinearGradient } from "expo-linear-gradient"

    import { Button } from "@/components/button"

import { useAppFonts } from "@/hooks/useAppFonts"

export default function Permission() {
    const isLoaded = useAppFonts()

    return (
        <KeyboardAvoidingView style={{ flex: 1 }} behavior={Platform.select({ ios: "padding", android: "height" })}>
            <ScrollView contentContainerStyle={{ flexGrow: 1 }}
                keyboardShouldPersistTaps="handled"
                showsVerticalScrollIndicator={false}
            >
                <View style={styles.container}>
                    <View>
                        <Image
                            source={require("@/assets/5ef03cfc1d1b0bbfe06051251d5947a839211bfb.png")}
                            style={styles.illustration}
                        />
                        <Text style={styles.title}>
                            Permita a sua localização
                        </Text>
                    </View>

                    <View>
                        <Text style={styles.textParagraph}>Para o seu aplicativo funcionar, permita o uso da sua localização GPS</Text>
                        <Text style={styles.textParagraph}>Isso facilita a procura das estações de bicicleta mais próximas para você começar a pedalar.</Text>
                        <Text style={styles.textParagraph}>Lembrete: você pode mudar essa opção nas configurações do aplicativo mais tarde.</Text>
                    </View>

                    <View>
                        <Button style={styles.button} label="Continuar" />
                        <Button style={styles.refuseButton} cores={["#FFFFFF"] } coresTexto="#004D88" label="Não permitir" />
                    </View>

                    <View>
                        <Text style={styles.footerText}>
                            Tem uma conta? <Link href="/" style={styles.footerLink}>Entre aqui.</Link> aqui.
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
        padding: 32,
        alignItems: "center",
        backgroundColor: "#FFFFFF"
        
    },
    illustration: {
        width: "100%",
        height: 102,
        resizeMode: "contain",
        marginTop: 62,
    },
    title: {
        fontSize: 36,
        fontFamily: "Roboto_700Bold",
        color: "#004D88",
        textAlign: "center"
    },
    textParagraph: {
        fontSize: 12,
        fontWeight: 600,
        textAlign: "center",
        marginTop: 20,
        color: "#517FA3"
    },
    button: {
        marginTop: 24,
        gap: 12,
        justifyContent: "center"
    },
    refuseButton:{
        backgroundColor: "#FFFFFF",
        color: "#004D88"
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