import { useState } from 'react';
import { Link } from 'expo-router';
import { KeyboardAvoidingView, Platform, ScrollView, StyleSheet } from 'react-native';

import { AuthButton } from '@/components/auth-button';
import { AuthHeader } from '@/components/auth-header';
import { AuthInput } from '@/components/auth-input';
import { ThemedText } from '@/components/themed-text';
import { ThemedView } from '@/components/themed-view';
import { MaxContentWidth, Spacing } from '@/constants/theme';

export default function SignupScreen() {
  const [name, setName] = useState('');
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [passwordConfirmation, setPasswordConfirmation] = useState('');

  return (
    <KeyboardAvoidingView
      style={styles.flex}
      behavior={Platform.OS === 'ios' ? 'padding' : undefined}>
      <ScrollView contentContainerStyle={styles.scrollContent}>
        <ThemedView style={styles.container}>
          <AuthHeader />

          <ThemedText type="title" style={styles.title}>
            Crie sua conta
          </ThemedText>
          <ThemedText themeColor="textSecondary" style={styles.subtitle}>
            Junte-se a milhares de equipes e organize seus projetos hoje mesmo.
          </ThemedText>

          <ThemedView style={styles.form}>
            <AuthInput label="Nome completo" placeholder="Seu nome" value={name} onChangeText={setName} />
            <AuthInput
              label="Email Corporativo"
              placeholder="nome@empresa.com"
              autoCapitalize="none"
              keyboardType="email-address"
              value={email}
              onChangeText={setEmail}
            />
            <AuthInput
              label="Senha"
              placeholder="********"
              secureTextEntry
              value={password}
              onChangeText={setPassword}
            />
            <AuthInput
              label="Confirme a senha"
              placeholder="********"
              secureTextEntry
              value={passwordConfirmation}
              onChangeText={setPasswordConfirmation}
            />

            <AuthButton title="Cadastre-se" />
          </ThemedView>

          <ThemedView style={styles.footer}>
            <ThemedText themeColor="textSecondary">Já tem uma conta?</ThemedText>
            <Link href="/login">
              <ThemedText type="linkPrimary">Entrar</ThemedText>
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
    gap: Spacing.one,
    marginTop: Spacing.four,
  },
});
