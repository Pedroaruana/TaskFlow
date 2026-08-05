import { useState } from 'react';
import { Link, useRouter } from 'expo-router';
import { KeyboardAvoidingView, Platform, ScrollView, StyleSheet } from 'react-native';

import { AuthButton } from '@/components/auth-button';
import { AuthHeader } from '@/components/auth-header';
import { AuthInput } from '@/components/auth-input';
import { ThemedText } from '@/components/themed-text';
import { ThemedView } from '@/components/themed-view';
import { MaxContentWidth, Spacing } from '@/constants/theme';

export default function ForgotPasswordScreen() {
  const router = useRouter();
  const [email, setEmail] = useState('');

  return (
    <KeyboardAvoidingView
      style={styles.flex}
      behavior={Platform.OS === 'ios' ? 'padding' : undefined}>
      <ScrollView contentContainerStyle={styles.scrollContent}>
        <ThemedView style={styles.container}>
          <AuthHeader />

          <ThemedText type="title" style={styles.title}>
            Esqueceu sua senha?
          </ThemedText>
          <ThemedText themeColor="textSecondary" style={styles.subtitle}>
            Digite seu email e enviaremos um código de verificação.
          </ThemedText>

          <ThemedView style={styles.form}>
            <AuthInput
              label="Email Corporativo"
              placeholder="nome@empresa.com"
              autoCapitalize="none"
              keyboardType="email-address"
              value={email}
              onChangeText={setEmail}
            />

            <AuthButton
              title="Enviar OTP"
              onPress={() => email.trim() && router.push('/verify-otp')}
            />
          </ThemedView>

          <ThemedView style={styles.footer}>
            <Link href="/login">
              <ThemedText type="link" themeColor="brandPrimary">Voltar para o login</ThemedText>
            </Link>
          </ThemedView>
        </ThemedView>
      </ScrollView>
    </KeyboardAvoidingView>
  );
}

const styles = StyleSheet.create({
  flex: {
    flex: 1,
  },
  scrollContent: {
    flexGrow: 1,
    justifyContent: 'center',
    alignItems: 'center',
  },
  container: {
    width: '100%',
    maxWidth: MaxContentWidth / 2,
    paddingHorizontal: Spacing.four,
    paddingVertical: Spacing.six,
    gap: Spacing.two,
  },
  title: {
    fontSize: 28,
    lineHeight: 34,
  },
  subtitle: {
    marginBottom: Spacing.three,
  },
  form: {
    gap: Spacing.three,
  },
  footer: {
    flexDirection: 'row',
    justifyContent: 'center',
    marginTop: Spacing.four,
  },
});
