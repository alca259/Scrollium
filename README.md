# Scrollium
Scrollium is a free and open source writing and publishing environment for long-form works.

It is designed for writers who need more than a traditional word processor: a place where manuscripts can be structured, revised, annotated, analyzed, versioned, and ultimately compiled into publication-ready documents.

Scrollium is inspired by applications such as Scrivener or Manuskript, but its goal is not to reproduce an existing application feature by feature. The project aims to build a more open, extensible, and technically ambitious environment for long-form writing.

## Why Scrollium?
The name combines *scroll*, referring to the ancient manuscript, with the suffix *-ium*, evoking a place or medium.

The name also has an unexpected historical echo: **Scrollium** was the title of an Amiga demo released by the programming group Escape in 1989.

## What is Scrollium?
Scrollium is intended to bring the entire writing and publishing workflow into a single environment.

A project can contain chapters, scenes, acts, notes, research material, characters, locations, timelines, revisions, and other supporting information. Documents can be organized in a flexible hierarchical binder, while individual pieces of writing remain independently editable and versionable.

The project is designed around a few fundamental principles:

* The manuscript belongs to the writer.
* Project files should remain understandable and recoverable without the application.
* Derived data should never become the source of truth.
* Saving a document should never require committing it to version control.
* Long-running operations should never block the writing experience.
* Expensive analysis should run incrementally and in the background.
* The architecture should remain extensible and friendly to community contributions.

## Rich text, plain text, and version control
Rich text is the primary editable representation of a document. Scrollium will use **RTF** as its persistent rich-text format, while automatically generating a canonical **TXT** representation.

The two representations serve different purposes:

* **RTF** preserves the rich document and its formatting. It will always be the source of truth.
* **TXT** provides a clean, human-readable representation suitable for diffs and version control.

Both representations are generated from the same document snapshot and can be tracked by Git.

This allows a Git diff to show meaningful textual changes without sacrificing the formatting required to restore the document faithfully.

Project structure and metadata will be stored separately from document content, using a lightweight, human-readable format such as JSON. The exact project format will be versioned and treated as a public specification rather than as a serialization detail of the C# implementation.

## Writing, revision, and analysis
Scrollium is intended to support both immediate feedback and deeper validation.

Basic spelling and typographic checks can run continuously while writing. More expensive analysis can be performed asynchronously on immutable document snapshots.

A validation pass can produce an **Editorial Diagnostics** view inspired by the error list found in modern IDEs. Diagnostics may include spelling, grammar, typography, structural problems, compilation issues, and, eventually, higher-level semantic inconsistencies.

Not every editorial problem can be determined through deterministic rules. Future versions will therefore support language-model-based analysis for tasks such as:

* character and relationship consistency;
* timeline and continuity checking;
* repeated concepts and patterns;
* stylistic analysis;
* cacophony and unwanted repetition;
* contextual orthotypographic suggestions;
* other forms of long-context editorial analysis.

Support is planned for using ONLY local language models, such as **Ollama**, as optional analysis providers. The analytics architecture will be vendor-agnostic, so other local models can be incorporated without coupling the application to a specific AI platform.

This will be completely optional and it will be the user's task to configure it. The application will never be allowed to connect with external AI providers, due to the authorship and plagiarism problems they entail.

These AI functionalities will under no circumstances be allowed to modify any text or document. Its only additional functionality is to locally analyze the content and provide the author with information or possible continuity errors.

## Compilation and publishing
Writing is only one part of the workflow.

Scrollium will include a compilation engine capable of transforming a project into different publication formats through configurable and duplicable compilation profiles.

In the long term, the aim is to accept formats in the following order:

* PDF;
* DOCX;
* Markdown;
* scripts and screenplay-oriented formats;
* and other structured or publication-oriented formats.

Compilation profiles will control things such as typography, fonts, margins, paragraph layout, chapter structure, headers and footers, page breaks, and other publication rules.

The compilation engine is intended to go beyond simple export. It will eventually provide enough control over pagination and typography for many books to be prepared for publication without requiring a separate desktop-publishing application for basic typesetting.

Features such as widow and orphan control, deterministic pagination, front and back matter, section-specific styling, and reusable compilation profiles are part of the long-term design.

## Version control
Scrollium will include built-in **Git** integration.

Git is intended to provide the underlying version-control mechanism without becoming part of the writer's mental model of the application.

Normal saving and versioning are therefore separate operations:

**Save** means that the current project state is safely persisted.

**Create a revision** means that the writer deliberately records a meaningful point in the history of the work.

This distinction allows writers to work normally while still benefiting from a complete and reliable history of their manuscripts.

Local Git repositories will be supported first, with remote repository integration planned for later versions.

## Timeline and project structure
Long-form works often depend on information that exists outside the immediate text.

Scrollium will therefore include a timeline where writers can record events, milestones, dates, annotations, and other information that may need to be considered while writing.

The timeline is intended to work alongside the project binder and other structured information, providing a way to reason about the chronology and continuity of a work.

The binder itself will support hierarchical organization of chapters, scenes, acts, revisions, notes, research material, and other project elements, with explicit metadata controlling their state and whether they participate in compilation.

## Technology
Scrollium is planned as a desktop-first application targeting:

* Windows
* Linux
* macOS

Mobile platforms are intentionally out of scope.

The initial technology stack is:

* **C# 14**
* **.NET 10**
* **Avalonia UI**
* **XAML**
* **System.Text.Json**
* **Git**
* **OpenOffice-compatible Hunspell dictionaries**

The UI will be built with Avalonia and XAML rather than targeting a mobile-oriented framework. This keeps the application focused on desktop environments while providing a common UI stack across Windows, Linux, and macOS.

## Performance
Performance is a first-class design goal.

Scrollium is intended to remain responsive when working with very large manuscripts and projects containing many documents.

The architecture will therefore be deliberately allocation-conscious, especially in hot paths such as text editing, parsing, searching, diffing, rendering, and incremental analysis.

Where appropriate, the implementation will make extensive use of modern .NET capabilities such as:

* `Span<T>` and `ReadOnlySpan<T>`;
* `Memory<T>` and related abstractions;
* pooled memory and `ArrayPool<T>`;
* value types and allocation-free data paths where practical;
* incremental processing;
* immutable snapshots;
* background processing;
* virtualization;
* and benchmark-driven optimization.

"Zero allocation" is not intended as a blanket rule for every operation in the application. The goal is to identify critical paths, define measurable allocation and latency budgets for them, and verify those budgets with benchmarks.

The application should never trade correctness or maintainability for a theoretical optimization. Performance decisions will be driven by measurements.

## Open source
Scrollium is released under the **GNU General Public License v3.0 (GPL-3.0)**.

The project is intended to be built collaboratively. The initial architecture and implementation provide the foundation, but the long-term direction of Scrollium will depend on its contributors and community.

The project therefore aims to keep its formats, interfaces, and architectural boundaries well documented, making it possible for contributors to work on individual areas without having to understand the entire application.

Scrollium is not intended to be a closed product with an open repository attached to it. The software, its formats, and its ecosystem are intended to remain open and extensible.

## Status
Scrollium is currently an early-stage project and a proof of concept.

The architecture is being designed before substantial implementation begins. Some technical decisions may change as prototypes, benchmarks, and real-world usage provide better evidence.

The first goal is not to build every feature at once, but to establish a solid foundation for the text engine, project model, persistence, editing experience, and compilation pipeline.

More documentation will be added as the project evolves.
